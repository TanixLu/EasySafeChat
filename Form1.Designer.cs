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
            this.OthersKeyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.OthersRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MyKeysTimer = new System.Windows.Forms.Timer(this.components);
            this.OthersKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.MyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MyKeysRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.OthersTextDecryptBtn = new System.Windows.Forms.Button();
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
            this.OthersKeyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersKeyRichTextBox.Location = new System.Drawing.Point(494, 3);
            this.OthersKeyRichTextBox.Name = "OthersKeyRichTextBox";
            this.OthersKeyRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OthersKeyRichTextBox.Size = new System.Drawing.Size(485, 49);
            this.OthersKeyRichTextBox.TabIndex = 1;
            this.OthersKeyRichTextBox.Text = "";
            this.OthersKeyRichTextBox.WordWrap = false;
            this.OthersKeyRichTextBox.TextChanged += new System.EventHandler(this.OthersKey_TextChanged);
            this.OthersKeyRichTextBox.DoubleClick += new System.EventHandler(this.OthersKeyTextBox_DoubleClick);
            // 
            // OthersRichTextBox
            // 
            this.OthersRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersRichTextBox.Location = new System.Drawing.Point(494, 58);
            this.OthersRichTextBox.Name = "OthersRichTextBox";
            this.OthersRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OthersRichTextBox.Size = new System.Drawing.Size(485, 436);
            this.OthersRichTextBox.TabIndex = 1;
            this.OthersRichTextBox.Text = "";
            this.OthersRichTextBox.WordWrap = false;
            this.OthersRichTextBox.DoubleClick += new System.EventHandler(this.OthersTextBox_DoubleClick);
            // 
            // MyKeysTimer
            // 
            this.MyKeysTimer.Interval = 500;
            this.MyKeysTimer.Tick += new System.EventHandler(this.MyKeysTimer_Tick);
            // 
            // OthersKeyTimer
            // 
            this.OthersKeyTimer.Interval = 500;
            this.OthersKeyTimer.Tick += new System.EventHandler(this.OthersKeyTimer_Tick);
            // 
            // MyRichTextBox
            // 
            this.MyRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyRichTextBox.Location = new System.Drawing.Point(3, 58);
            this.MyRichTextBox.Name = "MyRichTextBox";
            this.MyRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MyRichTextBox.Size = new System.Drawing.Size(485, 436);
            this.MyRichTextBox.TabIndex = 0;
            this.MyRichTextBox.Text = "";
            this.MyRichTextBox.WordWrap = false;
            this.MyRichTextBox.DoubleClick += new System.EventHandler(this.MyTextBox_DoubleClick);
            // 
            // MyKeysRichTextBox
            // 
            this.MyKeysRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyKeysRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.MyKeysRichTextBox.Name = "MyKeysRichTextBox";
            this.MyKeysRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MyKeysRichTextBox.Size = new System.Drawing.Size(485, 49);
            this.MyKeysRichTextBox.TabIndex = 2;
            this.MyKeysRichTextBox.Text = "";
            this.MyKeysRichTextBox.WordWrap = false;
            this.MyKeysRichTextBox.TextChanged += new System.EventHandler(this.MyKeys_TextChanged);
            this.MyKeysRichTextBox.DoubleClick += new System.EventHandler(this.MyKeysTextBox_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.OthersRichTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MyRichTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OthersKeyRichTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyKeysRichTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 553);
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
            this.tableLayoutPanel3.Controls.Add(this.OthersTextDecryptBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OthersTextEncryptBtn, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(494, 500);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(485, 50);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // OthersTextDecryptBtn
            // 
            this.OthersTextDecryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersTextDecryptBtn.Location = new System.Drawing.Point(100, 3);
            this.OthersTextDecryptBtn.Name = "OthersTextDecryptBtn";
            this.OthersTextDecryptBtn.Size = new System.Drawing.Size(91, 44);
            this.OthersTextDecryptBtn.TabIndex = 0;
            this.OthersTextDecryptBtn.Text = "←";
            this.OthersTextDecryptBtn.UseVisualStyleBackColor = true;
            this.OthersTextDecryptBtn.Click += new System.EventHandler(this.OthersTextDecryptBtn_Click);
            // 
            // OthersTextEncryptBtn
            // 
            this.OthersTextEncryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersTextEncryptBtn.Location = new System.Drawing.Point(294, 3);
            this.OthersTextEncryptBtn.Name = "OthersTextEncryptBtn";
            this.OthersTextEncryptBtn.Size = new System.Drawing.Size(91, 44);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 500);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(485, 50);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // MyTextDecryptBtn
            // 
            this.MyTextDecryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextDecryptBtn.Location = new System.Drawing.Point(100, 3);
            this.MyTextDecryptBtn.Name = "MyTextDecryptBtn";
            this.MyTextDecryptBtn.Size = new System.Drawing.Size(91, 44);
            this.MyTextDecryptBtn.TabIndex = 0;
            this.MyTextDecryptBtn.Text = "←";
            this.MyTextDecryptBtn.UseVisualStyleBackColor = true;
            this.MyTextDecryptBtn.Click += new System.EventHandler(this.MyTextDecryptBtn_Click);
            // 
            // MyTextEncryptBtn
            // 
            this.MyTextEncryptBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextEncryptBtn.Location = new System.Drawing.Point(294, 3);
            this.MyTextEncryptBtn.Name = "MyTextEncryptBtn";
            this.MyTextEncryptBtn.Size = new System.Drawing.Size(91, 44);
            this.MyTextEncryptBtn.TabIndex = 1;
            this.MyTextEncryptBtn.Text = "→";
            this.MyTextEncryptBtn.UseVisualStyleBackColor = true;
            this.MyTextEncryptBtn.Click += new System.EventHandler(this.MyTextEncryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.RichTextBox OthersKeyRichTextBox;
        private System.Windows.Forms.Timer MyKeysTimer;
        private System.Windows.Forms.Timer OthersKeyTimer;
        private System.Windows.Forms.RichTextBox MyRichTextBox;
        private System.Windows.Forms.RichTextBox MyKeysRichTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button OthersTextDecryptBtn;
        private System.Windows.Forms.Button OthersTextEncryptBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button MyTextDecryptBtn;
        private System.Windows.Forms.Button MyTextEncryptBtn;
    }
}

