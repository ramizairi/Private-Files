using Private_Files.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Private_Files
{


    public partial class Login : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        private void Login_Load(object sender, EventArgs e)
        {
        }
        public Login()
        {
            InitializeComponent();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (logemail.Text == Properties.Settings.Default.Email && logpassword.Text == Properties.Settings.Default.Password)
            {
                this.Hide();
                main mainform = new main();
                mainform.Show();

            }
            else
            {
                MessageBox.Show("Wrong Email Or Password", "Private Files");
            }
        }
        private void guna2ToggleSwitch1_StyleChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                logpassword.UseSystemPasswordChar = false;
            }
            else
            {
                logpassword.UseSystemPasswordChar = true;
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp forgform = new SignUp();
            forgform.Show();
        }

        private void forgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgotpassword forgform = new forgotpassword();
            forgform.Show();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            logpassword.UseSystemPasswordChar = true;
            if (guna2ToggleSwitch1.Checked)
            {
                logpassword.UseSystemPasswordChar = false;
            }

        }

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
    }
}
