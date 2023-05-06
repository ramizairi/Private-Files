using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Private_Files.Forms
{
    public partial class text : UserControl
    {
        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public text()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxEncryptedOutput.Text = Encrypt(textBoxInput.Text, textBoxEncryptPassword.Text, IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxDecryptOutput.Text = Decrypt(textBoxEncrypted.Text, textBoxDcryptPassword.Text, IV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            textBoxEncryptPassword.Enabled = textBoxInput.Text.Length > 0;
            buttonEncrypt.Enabled = textBoxInput.Text.Length > 0;
        }

        private void textBoxEncryptPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxInput.Enabled = textBoxInput.Text.Length > 0;
            buttonEncrypt.Enabled = textBoxInput.Text.Length > 0;
        }
        private void textBoxEncrypted_TextChanged(object sender, EventArgs e)
        {
            textBoxDcryptPassword.Enabled = textBoxInput.Text.Length > 0;
            buttonDecrypt.Enabled = textBoxInput.Text.Length > 0;
        }

        private void textBoxDcryptPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxEncrypted.Enabled = textBoxInput.Text.Length > 0;
            buttonDecrypt.Enabled = textBoxInput.Text.Length > 0;
        }

        private string Encrypt(string plainText, string Password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);
            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] InputBytes = Encoding.UTF8.GetBytes(plainText);
            cryptoStream.Write(InputBytes, 0, InputBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] Encrypted = memoryStream.ToArray();
            return Convert.ToBase64String(Encrypted);
        }

        private string Decrypt(string plaintext, string Password, byte[] IV)
        {
            byte[] Key = Encoding.UTF8.GetBytes(Password);
            AesManaged aes = new AesManaged();
            aes.Key = Key;
            aes.IV = IV;

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

            byte[] InputBytes = Convert.FromBase64String(plaintext);
            cryptoStream.Write(InputBytes, 0, InputBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] Decrypted = memoryStream.ToArray();
            return UTF8Encoding.UTF8.GetString(Decrypted, 0, Decrypted.Length);
        }

        private void textBoxInput_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length > 0)
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxInput.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            }

        }

        private void textBoxEncryptPassword_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxEncryptPassword.Text.Length > 0)
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxEncryptPassword.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            }
        }

        private void textBoxEncryptedOutput_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxEncryptedOutput.Text.Length > 0)
            {
                byte[] InputBytes = Convert.FromBase64String(textBoxEncryptedOutput.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
            }
        }

        private void textBoxEncrypted_DoubleClick(object sender, EventArgs e)
        {
            byte[] InputBytes = Convert.FromBase64String(textBoxEncrypted.Text);
            textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", " ");
        }

        private void textBoxDcryptPassword_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxDcryptPassword.Text.Length > 0)
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(textBoxDcryptPassword.Text);
                textBoxDebug.Text = BitConverter.ToString(InputBytes).ToLower().Replace("-", "");
            }
        }

        private void textBoxEncryptedOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEncryptedOutput.Text);
        }

        private void textBoxDecryptOutput_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEncryptedOutput.Text);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxEncryptPassword.Text = "";
            textBoxEncryptedOutput.Text = "";
            textBoxEncrypted.Text = "";
            textBoxDcryptPassword.Text = "";
            textBoxDecryptOutput.Text = "";
        }
    }
}
