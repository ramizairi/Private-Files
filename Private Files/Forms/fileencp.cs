using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Private_Files.Forms
{
    public partial class fileencp : UserControl
    {
        public fileencp()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Add files
            OpenFileDialog filepath = new OpenFileDialog();
            filepath.Title = "Select File";
            filepath.InitialDirectory = @"C:\";
            filepath.Filter = "All files (*.*)|*.*";
            filepath.Multiselect = true;
            filepath.FilterIndex = 1;
            filepath.ShowDialog();
            foreach (String file in filepath.FileNames)
            {
                listBox1.Items.Add(file);
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //Add folders
            FolderBrowserDialog folderpath = new FolderBrowserDialog();
            folderpath.ShowDialog();
            listBox2.Items.Add(folderpath.SelectedPath);
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int num = 0; num < listBox1.Items.Count; num++)
                {
                    string e_file = "" + listBox1.Items[num];
                    if (!e_file.Trim().EndsWith(".!LOCKED") && File.Exists(e_file))
                    {
                        EncryptFile("" + listBox1.Items[num], "" + listBox1.Items[num] + ".!LOCKED", Properties.Settings.Default.Password);
                        File.Delete("" + listBox1.Items[num]);
                    }
                }
                MessageBox.Show("File Encrypted Successfully", "Private Files");
            }
            if (listBox2.Items.Count > 0)
            {
                for (int num = 0; num < listBox2.Items.Count; num++)
                {
                    string d_file = "" + listBox2.Items[num];

                    try
                    {
                        string[] get_files = Directory.GetFiles(d_file, "*", SearchOption.AllDirectories);
                        foreach (string name_file in get_files)
                        {
                            if (!name_file.Trim().EndsWith(".!LOCKED") && File.Exists(name_file))
                            {
                                EncryptFile(name_file, name_file + ".!LOCKED", Properties.Settings.Default.Password);
                                File.Delete(name_file);
                            }
                        }
                    }
                    catch { }
                }
            }

        }

        private static readonly char[] value = { '!', '.', 'L', 'O', 'C', 'K', 'E', 'D' };
        char[] mychar = value;


        private void DecryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
            catch { }
        }

        private void EncryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch { }
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int num = 0; num < listBox1.Items.Count; num++)
                {
                    string e_file = "" + listBox1.Items[num];
                    if (e_file.Trim().EndsWith(".!LOCKED") && File.Exists(e_file))
                    {
                        DecryptFile(e_file, e_file.TrimEnd(mychar), Properties.Settings.Default.Password);
                        File.Delete(e_file);
                    }
                }
            }
            //selected folders
            if (listBox2.Items.Count > 0)
            {
                for (int num = 0; num < listBox2.Items.Count; num++)
                {
                    string d_file = "" + listBox2.Items[num];
                    string[] get_files = Directory.GetFiles(d_file);
                    foreach (string name_file in get_files)
                    {
                        if (name_file.Trim().EndsWith(".!LOCKED") && File.Exists(name_file))
                        {
                            DecryptFile(name_file, name_file.TrimEnd(mychar), Properties.Settings.Default.Password);
                            File.Delete(name_file);
                        }
                    }
                }
                MessageBox.Show("Folder decrypted Successfully", "Private Files");
            }

        }

        private void fileencp_Load(object sender, EventArgs e)
        {
        }
    }
}
