using System;
using System.Windows.Forms;

namespace StringEncrypter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e) {
            try {
                txtDestination.Text = txtSource.Text.Encrypt("自行設定的金鑰");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e) {
            try {
                txtDestination.Text = txtSource.Text.Decrypt("自行設定的金鑰");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOverWrite_Click(object sender, EventArgs e) {
            txtSource.Text = txtDestination.Text;
            txtDestination.Clear();
        }

        private void txtSource_KeyDown(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A) {
                ((TextBox)sender).SelectAll();
            }
        }

        private void txtDestination_KeyDown(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A) {
                ((TextBox)sender).SelectAll();
            }
        }

        private void txtSource_DoubleClick(object sender, EventArgs e) {
            ((TextBox)sender).Clear();
        }

        private void txtDestination_DoubleClick(object sender, EventArgs e) {
            ((TextBox)sender).Clear();
        }

        private void btnEncryptToClipboard_Click(object sender, EventArgs e) {
            try {
                var encryptText = txtSource.Text.Encrypt("自行設定的金鑰");
                Clipboard.SetText(encryptText);
                txtDestination.Text = string.Format("加密字串 {0} 已複製到系統剪貼簿", txtSource.Text);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtSource.Clear();
            txtDestination.Clear();
            txtSource.Focus();
        }
    }
}