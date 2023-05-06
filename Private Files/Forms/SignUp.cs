using System;
using System.Drawing;
using System.Windows.Forms;

namespace Private_Files.Forms
{
    public partial class SignUp : Form
    {
        private void SignUp_Load(object sender, EventArgs e)
        {
        }
        public SignUp()
        {
            InitializeComponent();
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            if (email.Text.Length == 0 || password.Text.Length == 0 || question.Text == "" || response.Text == "")
            {
                MessageBox.Show("Make sure that you fill all the blanks", "Private Files");
            }
            else
            {
                Properties.Settings.Default.Email = email.Text;
                if (password.Text.Length < 8)
                {
                    MessageBox.Show("Password must have 8 characters !", "Private Files");
                }
                else
                {
                    Properties.Settings.Default.Password = password.Text;
                    Properties.Settings.Default.SecurityQuestion = question.Text;
                    Properties.Settings.Default.SecurityAnswer = response.Text;
                    Properties.Settings.Default.Logged = true;
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Login loginform = new Login();
                    loginform.Show();
                }
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
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
    }
}
