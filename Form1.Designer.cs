namespace EasySafeChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OthersPublicKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OthersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MyPublicKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.OthersPublicKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.MyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MyPublicKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OthersTextEncryptBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MyTextDecryptBtn = new System.Windows.Forms.Button();
            this.MyTextEncryptBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OthersKeyRichTextBox
            // 
            this.OthersPublicKeyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPublicKeyRichTextBox.Location = new System.Drawing.Point(370, 2);
            this.OthersPublicKeyRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OthersPublicKeyRichTextBox.Name = "OthersKeyRichTextBox";
            this.OthersPublicKeyRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OthersPublicKeyRichTextBox.Size = new System.Drawing.Size(364, 40);
            this.OthersPublicKeyRichTextBox.TabIndex = 1;
            this.OthersPublicKeyRichTextBox.Text = "";
            this.OthersPublicKeyRichTextBox.WordWrap = false;
            this.OthersPublicKeyRichTextBox.TextChanged += new System.EventHandler(this.OthersPublicKey_TextChanged);
            this.OthersPublicKeyRichTextBox.DoubleClick += new System.EventHandler(this.OthersPublicKeyTextBox_DoubleClick);
            // 
            // OthersRichTextBox
            // 
            this.OthersRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersRichTextBox.Location = new System.Drawing.Point(370, 46);
            this.OthersRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OthersRichTextBox.Name = "OthersRichTextBox";
            this.OthersRichTextBox.Size = new System.Drawing.Size(364, 355);
            this.OthersRichTextBox.TabIndex = 1;
            this.OthersRichTextBox.Text = "";
            this.OthersRichTextBox.WordWrap = false;
            this.OthersRichTextBox.DoubleClick += new System.EventHandler(this.OthersTextBox_DoubleClick);
            // 
            // MyKeysTimer
            // 
            this.MyPublicKeyTimer.Interval = 500;
            this.MyPublicKeyTimer.Tick += new System.EventHandler(this.MyPublicKeyTimer_Tick);
            // 
            // OthersKeyTimer
            // 
            this.OthersPublicKeyTimer.Interval = 500;
            this.OthersPublicKeyTimer.Tick += new System.EventHandler(this.OthersPublicKeyTimer_Tick);
            // 
            // MyRichTextBox
            // 
            this.MyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyRichTextBox.Location = new System.Drawing.Point(2, 46);
            this.MyRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyRichTextBox.Name = "MyRichTextBox";
            this.MyRichTextBox.Size = new System.Drawing.Size(364, 355);
            this.MyRichTextBox.TabIndex = 0;
            this.MyRichTextBox.Text = "";
            this.MyRichTextBox.WordWrap = false;
            this.MyRichTextBox.DoubleClick += new System.EventHandler(this.MyTextBox_DoubleClick);
            // 
            // MyKeysRichTextBox
            // 
            this.MyPublicKeyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPublicKeyRichTextBox.Location = new System.Drawing.Point(2, 2);
            this.MyPublicKeyRichTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyPublicKeyRichTextBox.Name = "MyKeysRichTextBox";
            this.MyPublicKeyRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MyPublicKeyRichTextBox.Size = new System.Drawing.Size(364, 40);
            this.MyPublicKeyRichTextBox.TabIndex = 2;
            this.MyPublicKeyRichTextBox.Text = "";
            this.MyPublicKeyRichTextBox.WordWrap = false;
            this.MyPublicKeyRichTextBox.TextChanged += new System.EventHandler(this.MyPublicKey_TextChanged);
            this.MyPublicKeyRichTextBox.DoubleClick += new System.EventHandler(this.MyPublicKeyTextBox_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OthersRichTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MyRichTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OthersPublicKeyRichTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyPublicKeyRichTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 449);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.OthersTextEncryptBtn, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(370, 405);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(364, 42);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // OthersTextEncryptBtn
            // 
            this.OthersTextEncryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersTextEncryptBtn.Location = new System.Drawing.Point(146, 2);
            this.OthersTextEncryptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OthersTextEncryptBtn.Name = "OthersTextEncryptBtn";
            this.OthersTextEncryptBtn.Size = new System.Drawing.Size(68, 38);
            this.OthersTextEncryptBtn.TabIndex = 1;
            this.OthersTextEncryptBtn.Text = "→";
            this.OthersTextEncryptBtn.UseVisualStyleBackColor = true;
            this.OthersTextEncryptBtn.Click += new System.EventHandler(this.OthersTextEncryptBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.MyTextDecryptBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.MyTextEncryptBtn, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 405);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(364, 42);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // MyTextDecryptBtn
            // 
            this.MyTextDecryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextDecryptBtn.Location = new System.Drawing.Point(74, 2);
            this.MyTextDecryptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyTextDecryptBtn.Name = "MyTextDecryptBtn";
            this.MyTextDecryptBtn.Size = new System.Drawing.Size(68, 38);
            this.MyTextDecryptBtn.TabIndex = 0;
            this.MyTextDecryptBtn.Text = "←";
            this.MyTextDecryptBtn.UseVisualStyleBackColor = true;
            this.MyTextDecryptBtn.Click += new System.EventHandler(this.MyTextDecryptBtn_Click);
            // 
            // MyTextEncryptBtn
            // 
            this.MyTextEncryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextEncryptBtn.Location = new System.Drawing.Point(218, 2);
            this.MyTextEncryptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyTextEncryptBtn.Name = "MyTextEncryptBtn";
            this.MyTextEncryptBtn.Size = new System.Drawing.Size(68, 38);
            this.MyTextEncryptBtn.TabIndex = 1;
            this.MyTextEncryptBtn.Text = "→";
            this.MyTextEncryptBtn.UseVisualStyleBackColor = true;
            this.MyTextEncryptBtn.Click += new System.EventHandler(this.MyTextEncryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Easy Safe Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox OthersRichTextBox;
        private System.Windows.Forms.RichTextBox OthersPublicKeyRichTextBox;
        private System.Windows.Forms.Timer MyPublicKeyTimer;
        private System.Windows.Forms.Timer OthersPublicKeyTimer;
        private System.Windows.Forms.RichTextBox MyRichTextBox;
        private System.Windows.Forms.RichTextBox MyPublicKeyRichTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button OthersTextEncryptBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MyTextDecryptBtn;
        private System.Windows.Forms.Button MyTextEncryptBtn;
    }
}

