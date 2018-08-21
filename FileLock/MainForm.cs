using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileLock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static string txtOutFile = "";
        private static string extension = "";
        private void btnInFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                if (ofd.FileName != null)
                {
                    extension = System.IO.Path.GetExtension(ofd.FileName);//扩展名
                    if (extension == ".encrypted")
                    {
                        btnEncy.Enabled = false;
                        btnDecy.Enabled = true;
                    }
                    else
                    {
                        btnEncy.Enabled = true;
                        btnDecy.Enabled = false;
                    }
                    txtInFile.Text = ofd.FileName;

                }
            }
        }

        private void btnEncy_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutFile = txtInFile.Text + ".encrypted";
                CryptoHelp.EncryptFile(txtInFile.Text, txtOutFile, txtPassWord.Text.Trim());
                MessageBox.Show("加密成功！");
                ClearTextBox();
            }
            catch (CryptoHelpException che)
            {
                MessageBox.Show(che.Message);
            }
        }

        private void btnDecy_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "请选择解密文件保存位置";
                extension = System.IO.Path.GetExtension(txtInFile.Text.Replace(".encrypted", ""));//扩展名
                sfd.Filter = "" + extension + "|*" + extension;
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    txtOutFile = sfd.FileName;
                    try
                    {
                        CryptoHelp.DecryptFile(txtInFile.Text, txtOutFile, txtPassWord.Text.Trim());
                        MessageBox.Show("解密成功！");
                        ClearTextBox();
                    }
                    catch (CryptoHelpException che)
                    {
                        MessageBox.Show(che.Message);
                    }
                }
                else
                {
                }
            }

        }

        private void ClearTextBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
                else if (c is Button)
                {
                    c.Enabled = false;
                }
            }
            btnInFile.Enabled = true;
        }

        private void txtInFile_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            extension = System.IO.Path.GetExtension(path);//扩展名
            if (extension == ".encrypted")
            {
                btnEncy.Enabled = false;
                btnDecy.Enabled = true;
            }
            else
            {
                btnEncy.Enabled = true;
                btnDecy.Enabled = false;
            }
            txtInFile.Text = path;
        }

        private void txtInFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtInFile.Text = "";
        }

        private void txtInFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Move;
            else e.Effect = DragDropEffects.None;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            extension = System.IO.Path.GetExtension(path);//扩展名
            if (extension == ".encrypted")
            {
                btnEncy.Enabled = false;
                btnDecy.Enabled = true;
            }
            else
            {
                btnEncy.Enabled = true;
                btnDecy.Enabled = false;
            }
            txtInFile.Text = path;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string command = Environment.CommandLine;//获取进程命令行参数
            string[] para = command.Split('\"');
            if (para.Length > 4)
            {
                if (para[3].Length > 25)
                {
                    extension = System.IO.Path.GetExtension(para[3]);//扩展名
                    if (extension == ".encrypted")
                    {
                        btnEncy.Enabled = false;
                        btnDecy.Enabled = true;
                    }
                    else
                    {
                        btnEncy.Enabled = true;
                        btnDecy.Enabled = false;
                    }
                    //txtInFile.Text = path;
                    txtInFile.Text = para[3];//第四个参数是该文件的地址
                }
            }
        }
    }
}
