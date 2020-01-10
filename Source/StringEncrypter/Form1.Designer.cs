namespace StringEncrypter {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOverWrite = new System.Windows.Forms.Button();
            this.btnEncryptToClipboard = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSource.Location = new System.Drawing.Point(13, 28);
            this.txtSource.Margin = new System.Windows.Forms.Padding(4);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(1121, 214);
            this.txtSource.TabIndex = 0;
            this.txtSource.DoubleClick += new System.EventHandler(this.txtSource_DoubleClick);
            this.txtSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSource_KeyDown);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDestination.Location = new System.Drawing.Point(16, 273);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDestination.Size = new System.Drawing.Size(1121, 214);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.DoubleClick += new System.EventHandler(this.txtDestination_DoubleClick);
            this.txtDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestination_KeyDown);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEncrypt.Location = new System.Drawing.Point(225, 495);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(200, 31);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "加密來源字串→目的字串";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDecrypt.Location = new System.Drawing.Point(641, 495);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(200, 31);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "解密來源字串→目的字串";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "來源字串";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "目的字串";
            // 
            // btnOverWrite
            // 
            this.btnOverWrite.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOverWrite.Location = new System.Drawing.Point(848, 495);
            this.btnOverWrite.Name = "btnOverWrite";
            this.btnOverWrite.Size = new System.Drawing.Size(200, 31);
            this.btnOverWrite.TabIndex = 5;
            this.btnOverWrite.Text = "覆蓋目的字串→來源字串";
            this.btnOverWrite.UseVisualStyleBackColor = true;
            this.btnOverWrite.Click += new System.EventHandler(this.btnOverWrite_Click);
            // 
            // btnEncryptToClipboard
            // 
            this.btnEncryptToClipboard.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEncryptToClipboard.Location = new System.Drawing.Point(433, 495);
            this.btnEncryptToClipboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncryptToClipboard.Name = "btnEncryptToClipboard";
            this.btnEncryptToClipboard.Size = new System.Drawing.Size(200, 31);
            this.btnEncryptToClipboard.TabIndex = 6;
            this.btnEncryptToClipboard.Text = "加密來源字串→剪貼簿";
            this.btnEncryptToClipboard.UseVisualStyleBackColor = true;
            this.btnEncryptToClipboard.Click += new System.EventHandler(this.btnEncryptToClipboard_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(1054, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 31);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空字串";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 538);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEncryptToClipboard);
            this.Controls.Add(this.btnOverWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Font = new System.Drawing.Font("細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "字串加/解密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOverWrite;
        private System.Windows.Forms.Button btnEncryptToClipboard;
        private System.Windows.Forms.Button btnClear;
    }
}

