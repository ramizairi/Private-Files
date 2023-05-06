using System;
using System.Drawing;
using System.Windows.Forms;

namespace Private_Files.Forms
{
    public partial class forgotpassword : Form
    {
        public forgotpassword()
        {
            InitializeComponent();
        }


        private void GetPass_Click_1(object sender, EventArgs e)
        {
            if (email.Text == "" || response.Text == "" || question.Text == "")
            {
                MessageBox.Show("Email, Security question or Answare are empty", "Private Files");
            }
            else if (Properties.Settings.Default.Email == email.Text && Properties.Settings.Default.SecurityQuestion == question.Text && Properties.Settings.Default.SecurityAnswer == response.Text)
            {
                MessageBox.Show(Properties.Settings.Default.Password, "Private File");
                this.Hide();
                Login loginform = new Login();
                loginform.Show();
            }
            else
            {
                MessageBox.Show("Wrong Email or Answare");
            }
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

        private void forgotpassword_Load(object sender, EventArgs e)
        {
        }
    }
}
