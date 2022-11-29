using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Numerics;

namespace EasySafeChat
{
    public partial class Form1 : Form
    {
        private const int N_BITS = 4096;
        private const int D_BYTES = N_BITS / 8;
        private const int Q_BYTES = D_BYTES / 2;
        private const int DP_BYTES = Q_BYTES;
        private const int DQ_BYTES = Q_BYTES;
        private const int INV_Q_BYTES = Q_BYTES;
        private static readonly byte[] EXPONENT = new byte[] { 0x01, 0x00, 0x01 };  // 65537
        private const bool USE_OAEP = true;
        private const int ENC_BLOCK_BYTES = D_BYTES;
        private const int HASH_BYTES = 20;
        private const int BLOCK_BYTES = ENC_BLOCK_BYTES - 2 * HASH_BYTES - 2;

        // 密钥文件格式：第一行是n，第二行是p（可选）
        private const string MY_KEYS_PATH = "MyKeys.txt";
        private const string OTHERS_KEY_PATH = "OthersPublicKey.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private static RSAParameters GetFullParams(byte[] n, byte[] p)
        {
            var otherParams = CalcOtherParams(n, p);

            return new RSAParameters
            {
                P = p,
                Q = otherParams.Q,
                Exponent = EXPONENT,
                Modulus = n,
                D = otherParams.D,
                DP = otherParams.DP,
                DQ = otherParams.DQ,
                InverseQ = otherParams.InverseQ,
            };
        }

        private static RSAParameters CalcOtherParams(byte[] _n, byte[] _p)
        {
            var n = BigIntegerFromBigEndian(_n);
            var p = BigIntegerFromBigEndian(_p);
            var e = BigIntegerFromBigEndian(EXPONENT);
            var q = n / p;
            var phiN = n - p - q + 1; // OR: (p - 1) * (q - 1);
            var d = CoprimesModInverse(e, phiN);
            var dp = d % (p - 1);
            var dq = d % (q - 1);
            var qInv = CoprimesModInverse(q, p);
            return new RSAParameters
            {
                Q = ReversedBytes(q.ToByteArray(), Q_BYTES),
                D = ReversedBytes(d.ToByteArray(), D_BYTES),
                DP = ReversedBytes(dp.ToByteArray(), DP_BYTES),
                DQ = ReversedBytes(dq.ToByteArray(), DQ_BYTES),
                InverseQ = ReversedBytes(qInv.ToByteArray(), INV_Q_BYTES)
            };
        }

        private static byte[] ReversedBytes(byte[] data, int len = 0)
        {
            var reversed = new byte[data.Length];
            Array.Copy(data, 0, reversed, 0, data.Length);
            if (len > 0) Array.Resize(ref reversed, len);
            Array.Reverse(reversed);
            return reversed;
        }

        private static BigInteger BigIntegerFromBigEndian(byte[] bigEndian)
        {
            var littleEndian = ReversedBytes(bigEndian);
            // 最高位是1要补零，否则被识别为负数
            if (bigEndian[0] >= 128) littleEndian = littleEndian.Concat(new byte[] { 0 }).ToArray();
            return new BigInteger(littleEndian);
        }

        // Returns modulo inverse of a with
        // respect to m using extended Euclid
        // Algorithm Assumption: a and m are
        // coprimes, i.e., gcd(A, M) = 1
        private static BigInteger CoprimesModInverse(BigInteger A, BigInteger M)
        {
            BigInteger m0 = M;
            BigInteger y = 0, x = 1;

            if (M == 1) return 0;

            while (A > 1)
            {
                // q is quotient
                BigInteger q = A / M;

                BigInteger t = M;

                // m is remainder now, process
                // same as Euclid's algo
                M = A % M;
                A = t;
                t = y;

                // Update x and y
                y = x - q * y;
                x = t;
            }

            // Make x positive
            if (x < 0)
                x += m0;

            return x;
        }

        private RSACryptoServiceProvider GetMyRsa()
        {
            if (MyKeysRichTextBox.Text.Length > 0)
            {
                try
                {
                    var rsaParams = GetFullParams(
                        Convert.FromBase64String(MyKeysRichTextBox.Lines[0].Trim()),
                        Convert.FromBase64String(MyKeysRichTextBox.Lines[1].Trim())
                    );
                    var myRsa = new RSACryptoServiceProvider();
                    myRsa.ImportParameters(rsaParams);
                    return myRsa;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        "你的密钥格式错误，请将其修复或清空",
                        "错误",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                    return null;
                }
            }
            else
            {
                // 如果为空，则生成新密钥
                var myRsa = new RSACryptoServiceProvider(N_BITS);
                var rsaParams = myRsa.ExportParameters(true);
                MyKeysRichTextBox.Lines = new string[] {
                    Convert.ToBase64String(rsaParams.Modulus),
                    Convert.ToBase64String(rsaParams.P),
                };

                // 立即存入文件
                MyKeysTimer_Tick(null, null);

                return myRsa;
            }
        }

        private RSACryptoServiceProvider GetOthersRsa()
        {
            if (OthersKeyRichTextBox.Text.Length > 0)
            {
                try
                {
                    var rsaParams = new RSAParameters
                    {
                        Exponent = EXPONENT,
                        Modulus = Convert.FromBase64String(OthersKeyRichTextBox.Lines[0].Trim())
                    };
                    var othersRsa = new RSACryptoServiceProvider();
                    othersRsa.ImportParameters(rsaParams);
                    return othersRsa;
                }
                catch (Exception)
                {
                    MessageBox.Show(
                        $"对方公钥格式错误，请修复",
                        "错误",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                }
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(MY_KEYS_PATH))
                MyKeysRichTextBox.Text = File.ReadAllText(MY_KEYS_PATH);
            if (MyKeysRichTextBox.Text.Length == 0) GetMyRsa();
            if (File.Exists(OTHERS_KEY_PATH))
                OthersKeyRichTextBox.Text = File.ReadAllText(OTHERS_KEY_PATH);
            if (OthersKeyRichTextBox.Text.Length == 0)
                OthersKeyRichTextBox.Text = "请填入对方公钥";
        }

        private void MyKeys_TextChanged(object sender, EventArgs e)
        {
            MyKeysTimer.Stop();
            MyKeysTimer.Start();
        }

        private void OthersKey_TextChanged(object sender, EventArgs e)
        {
            OthersKeyTimer.Stop();
            OthersKeyTimer.Start();
        }

        private void MyKeysTimer_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(MY_KEYS_PATH, MyKeysRichTextBox.Text);
        }

        private void OthersKeyTimer_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(OTHERS_KEY_PATH, OthersKeyRichTextBox.Text);
        }

        private void SelectCurrentLine(RichTextBox textBox)
        {
            var start = textBox.GetFirstCharIndexOfCurrentLine();
            var lineIndex = textBox.GetLineFromCharIndex(start);
            if (lineIndex < textBox.Lines.Length)
            {
                var end = textBox.Lines[lineIndex].Length;
                textBox.Select(start, end);
            }
        }

        private void MyKeysTextBox_DoubleClick(object sender, EventArgs e)
        {
            SelectCurrentLine(MyKeysRichTextBox);
        }

        private void OthersKeyTextBox_DoubleClick(object sender, EventArgs e)
        {
            SelectCurrentLine(OthersKeyRichTextBox);
        }

        private void MyTextBox_DoubleClick(object sender, EventArgs e)
        {
            SelectCurrentLine(MyRichTextBox);
        }

        private void OthersTextBox_DoubleClick(object sender, EventArgs e)
        {
            SelectCurrentLine(OthersRichTextBox);
        }

        private void RsaEncrypt(RichTextBox richTextBox, RSACryptoServiceProvider rsa)
        {
            if (richTextBox.Text.Length == 0 || rsa is null) return;
            try
            {
                var plainBytes = Encoding.UTF8.GetBytes(richTextBox.Text);
                // 将plainBytes分块加密、整合
                byte[] plainBuffer;
                var cipherBytesList = new List<byte>();
                for (int i = 0; i < plainBytes.Length; i += BLOCK_BYTES)
                {
                    var len = plainBytes.Length - i < BLOCK_BYTES ? plainBytes.Length - i : BLOCK_BYTES;
                    plainBuffer = new byte[len];
                    Array.Copy(plainBytes, i, plainBuffer, 0, len);
                    cipherBytesList.AddRange(rsa.Encrypt(plainBuffer, USE_OAEP));
                }
                var cipherBytes = cipherBytesList.ToArray();
                var cipherBase64 = Convert.ToBase64String(cipherBytes);
                richTextBox.Text = cipherBase64;
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "加密失败！", "错误",
                   MessageBoxButtons.OK, MessageBoxIcon.Error
               );
            }
        }

        private void RsaDecrypt(RichTextBox richTextBox, RSACryptoServiceProvider rsa)
        {
            if (richTextBox.Text.Length == 0 || rsa is null) return;
            try
            {
                var cipherBytes = Convert.FromBase64String(richTextBox.Text);
                // 将cipherBytes分块解密、整合
                byte[] cipherBuffer;
                var plainBytesList = new List<byte>();
                for (int i = 0; i < cipherBytes.Length; i += ENC_BLOCK_BYTES)
                {
                    cipherBuffer = new byte[ENC_BLOCK_BYTES];
                    Array.Copy(cipherBytes, i, cipherBuffer, 0, ENC_BLOCK_BYTES);
                    plainBytesList.AddRange(rsa.Decrypt(cipherBuffer, USE_OAEP));
                }
                var plainBytes = plainBytesList.ToArray();
                var plainText = Encoding.UTF8.GetString(plainBytes);
                richTextBox.Text = plainText;
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "解密失败！", "错误",
                   MessageBoxButtons.OK, MessageBoxIcon.Error
               );
            }
        }

        private void MyTextEncryptBtn_Click(object sender, EventArgs e)
        {
            RsaEncrypt(MyRichTextBox, GetMyRsa());
        }

        private void MyTextDecryptBtn_Click(object sender, EventArgs e)
        {
            RsaDecrypt(MyRichTextBox, GetMyRsa());
        }

        private void OthersTextEncryptBtn_Click(object sender, EventArgs e)
        {
            RsaEncrypt(OthersRichTextBox, GetOthersRsa());
        }

        private void OthersTextDecryptBtn_Click(object sender, EventArgs e)
        {
            RsaDecrypt(OthersRichTextBox, GetOthersRsa());
        }
    }
}
