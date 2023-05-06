using System;
using System.Drawing;
using System.Windows.Forms;


namespace Private_Files.Forms
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            text1.Visible = false;
            fileencp1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            text1.Visible = true;
            fileencp1.Visible = false;

        }

        private void fileencp1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginform = new Login();
            loginform.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string filePath = $@"C:\Users\{userName}\Pictures\screenshot.png";
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            bitmap.Save(filePath);
            graphics.Dispose();
            bitmap.Dispose();
            MessageBox.Show("ScreenShot saved successfully", "Private Files");
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("1HHok6Xb5kAQzTj5EspLSuP28qA5xALWqE");
            MessageBox.Show("Bitcoin address copied successfully", "Thank You !!!!");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string url = "https://linktr.ee/medramizairi";
            System.Diagnostics.Process.Start(url);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void main_Load(object sender, EventArgs e)
        {
        }
    }
}
