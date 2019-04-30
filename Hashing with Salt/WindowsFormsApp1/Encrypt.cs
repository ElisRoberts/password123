using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnHash.Enabled = true;
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            if (rbSHA1.Checked == true)
            {
                SHA1Managed sha = new SHA1Managed();
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(txtSalt.Text + txtInput.Text));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                txtCode.Text = sb.ToString();
            }
            else if (rbSHA256.Checked == true)
            {
                SHA256Managed sha = new SHA256Managed();
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(txtSalt.Text + txtInput.Text));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                txtCode.Text = sb.ToString();
            }
            else if (rbSHA512.Checked == true)
            {
                SHA512Managed sha = new SHA512Managed();
                var hash = sha.ComputeHash(Encoding.UTF8.GetBytes(txtSalt.Text + txtInput.Text));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                txtCode.Text = sb.ToString();
            }

            //string password = txtInput.Text;

            //byte[] bytes = Encoding.Unicode.GetBytes(password);
            //byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            //txtCode.Text = Convert.ToBase64String(inArray);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
