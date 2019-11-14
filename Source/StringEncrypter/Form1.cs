using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEncrypter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e) {
            txtDestination.Text = txtSource.Text.Encrypt("自行設定的金鑰");
        }

        private void btnDecrypt_Click(object sender, EventArgs e) {
            txtDestination.Text = txtSource.Text.Decrypt("自行設定的金鑰");
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
    }
}