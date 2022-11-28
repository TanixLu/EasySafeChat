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

namespace EasySafeChat
{
    public partial class Form1 : Form
    {
        private static readonly ECCurve CURVE = ECCurve.NamedCurves.nistP521;
        // 密钥存储格式：第一行X，第二行Y（X和Y组成公钥），第三行D（私钥，可不填）
        private const string MY_KEYS_PATH = "MyKeys.txt";
        private const string OTHERS_PUBLIC_KEY_PATH = "OthersPublicKey.txt";
        private static ECDsa MyEcdsa { get; set; }
        private static ECDsa OthersEcdsa { get; set; }

        private static ECDsa LoadEcdsaFromHex(string xHex, string yHex, string privateHex = null)
        {
            try
            {
                return ECDsa.Create(new ECParameters
                {
                    Curve = CURVE,
                    Q = new ECPoint
                    {
                        X = HexToByteArray(xHex),
                        Y = HexToByteArray(yHex)
                    },
                    D = HexToByteArray(privateHex)
                });
            }
            catch (Exception)
            {
                return null;
            }
        }

        private static void SaveEcdsa2File(string path, ECDsa ecdsa)
        {
            var xHex = ByteArrayToHex(ecdsa.ExportParameters(false).Q.X);
            var yHex = ByteArrayToHex(ecdsa.ExportParameters(false).Q.Y);
            string[] lines;
            try
            {
                var dHex = ByteArrayToHex(ecdsa.ExportParameters(true).D);
                lines = new string[] { xHex, yHex, dHex };
            }
            catch (CryptographicException)
            {
                lines = new string[] { xHex, yHex };
            }
            File.WriteAllLines(path, lines);
        }

        private static ECDsa LoadEcdsaFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            if (lines.Length < 2) return null;
            else if (lines.Length == 2) return LoadEcdsaFromHex(lines[0].Trim(), lines[1].Trim());
            else return LoadEcdsaFromHex(lines[0].Trim(), lines[1].Trim(), lines[2].Trim());
        }

        private static byte[] HexToByteArray(string hex)
        {
            if (hex is null) return null;
            else
            {
                int numberChars = hex.Length;
                byte[] bytes = new byte[numberChars / 2];
                for (int i = 0; i < numberChars; i += 2)
                    bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
                return bytes;
            }
        }

        public static string ByteArrayToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(MY_KEYS_PATH) && new FileInfo(MY_KEYS_PATH).Length != 0)
            {
                MyEcdsa = LoadEcdsaFromFile(MY_KEYS_PATH);
                if (MyEcdsa is null) MessageBox.Show(
                    $"文件{MY_KEYS_PATH}格式错误，请将其修复或清空",
                    "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            else
            {
                MyEcdsa = ECDsa.Create(CURVE);
                SaveEcdsa2File(MY_KEYS_PATH, MyEcdsa);
                MessageBox.Show(
                    $"成功生成密钥！已保存至{MY_KEYS_PATH}",
                    "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
            if (File.Exists(OTHERS_PUBLIC_KEY_PATH) && new FileInfo(OTHERS_PUBLIC_KEY_PATH).Length != 0)
            {
                OthersEcdsa = LoadEcdsaFromFile(OTHERS_PUBLIC_KEY_PATH);
                if (OthersEcdsa is null) MessageBox.Show(
                    $"文件{OTHERS_PUBLIC_KEY_PATH}格式错误，请修复或将其清空",
                    "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text
        }
    }
}
