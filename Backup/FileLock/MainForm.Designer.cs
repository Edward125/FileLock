namespace FileLock
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInFile = new System.Windows.Forms.Button();
            this.txtInFile = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnEncy = new System.Windows.Forms.Button();
            this.btnDecy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInFile
            // 
            this.btnInFile.Location = new System.Drawing.Point(205, 25);
            this.btnInFile.Name = "btnInFile";
            this.btnInFile.Size = new System.Drawing.Size(75, 23);
            this.btnInFile.TabIndex = 0;
            this.btnInFile.Text = "目标文件";
            this.btnInFile.UseVisualStyleBackColor = true;
            this.btnInFile.Click += new System.EventHandler(this.btnInFile_Click);
            // 
            // txtInFile
            // 
            this.txtInFile.AllowDrop = true;
            this.txtInFile.Location = new System.Drawing.Point(13, 25);
            this.txtInFile.Name = "txtInFile";
            this.txtInFile.ReadOnly = true;
            this.txtInFile.Size = new System.Drawing.Size(186, 21);
            this.txtInFile.TabIndex = 1;
            this.txtInFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtInFile_DragDrop);
            this.txtInFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInFile_KeyPress);
            this.txtInFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtInFile_DragEnter);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(13, 68);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(186, 21);
            this.txtPassWord.TabIndex = 4;
            // 
            // btnEncy
            // 
            this.btnEncy.Enabled = false;
            this.btnEncy.Location = new System.Drawing.Point(13, 107);
            this.btnEncy.Name = "btnEncy";
            this.btnEncy.Size = new System.Drawing.Size(75, 23);
            this.btnEncy.TabIndex = 5;
            this.btnEncy.Text = "加密";
            this.btnEncy.UseVisualStyleBackColor = true;
            this.btnEncy.Click += new System.EventHandler(this.btnEncy_Click);
            // 
            // btnDecy
            // 
            this.btnDecy.Enabled = false;
            this.btnDecy.Location = new System.Drawing.Point(117, 107);
            this.btnDecy.Name = "btnDecy";
            this.btnDecy.Size = new System.Drawing.Size(75, 23);
            this.btnDecy.TabIndex = 6;
            this.btnDecy.Text = "解密";
            this.btnDecy.UseVisualStyleBackColor = true;
            this.btnDecy.Click += new System.EventHandler(this.btnDecy_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(206, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "密码，解密时也是用此密码";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecy);
            this.Controls.Add(this.btnEncy);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtInFile);
            this.Controls.Add(this.btnInFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "文件加密解密";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInFile;
        private System.Windows.Forms.TextBox txtInFile;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnEncy;
        private System.Windows.Forms.Button btnDecy;
        private System.Windows.Forms.Label label1;
    }
}

