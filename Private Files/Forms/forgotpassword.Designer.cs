namespace Private_Files.Forms
{
    partial class forgotpassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpassword));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.response = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.question = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.GetPass = new Guna.UI2.WinForms.Guna2Button();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // response
            // 
            this.response.BorderRadius = 10;
            this.response.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.response.DefaultText = "";
            this.response.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.response.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.response.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.response.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.response.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.response.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.response.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response.ForeColor = System.Drawing.Color.White;
            this.response.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.response.Location = new System.Drawing.Point(39, 354);
            this.response.Name = "response";
            this.response.PasswordChar = '\0';
            this.response.PlaceholderText = "Write here";
            this.response.SelectedText = "";
            this.response.Size = new System.Drawing.Size(233, 41);
            this.response.TabIndex = 32;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(21, 275);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(125, 22);
            this.guna2HtmlLabel5.TabIndex = 31;
            this.guna2HtmlLabel5.Text = "Security question";
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.Color.Transparent;
            this.question.BorderRadius = 10;
            this.question.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.question.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.question.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.question.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.question.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.question.ForeColor = System.Drawing.Color.White;
            this.question.ItemHeight = 30;
            this.question.Items.AddRange(new object[] {
            "What is your favorite color?",
            "What is your pet\'s name?",
            "What is your favorite movie?",
            "What is your favorite book?",
            "What is your favorite food?"});
            this.question.Location = new System.Drawing.Point(39, 303);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(233, 36);
            this.question.TabIndex = 30;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 177);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(42, 22);
            this.guna2HtmlLabel1.TabIndex = 29;
            this.guna2HtmlLabel1.Text = "Email";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-11, -6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(361, 43);
            this.guna2Panel1.TabIndex = 27;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(17, 13);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(88, 22);
            this.guna2HtmlLabel4.TabIndex = 20;
            this.guna2HtmlLabel4.Text = "Private Files";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(276, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // GetPass
            // 
            this.GetPass.BorderRadius = 10;
            this.GetPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GetPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GetPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(123)))), ((int)(((byte)(100)))));
            this.GetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPass.ForeColor = System.Drawing.Color.White;
            this.GetPass.Image = global::Private_Files.Properties.Resources.interface_user_check;
            this.GetPass.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GetPass.Location = new System.Drawing.Point(39, 428);
            this.GetPass.Name = "GetPass";
            this.GetPass.Size = new System.Drawing.Size(233, 45);
            this.GetPass.TabIndex = 33;
            this.GetPass.Text = "Get Your Password";
            this.GetPass.Click += new System.EventHandler(this.GetPass_Click_1);
            // 
            // email
            // 
            this.email.Animated = true;
            this.email.BorderRadius = 10;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.IconRight = global::Private_Files.Properties.Resources.interface_user_edit;
            this.email.Location = new System.Drawing.Point(39, 205);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "exemple@exemple.com";
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(233, 41);
            this.email.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Private_Files.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(99, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // forgotpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(311, 531);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GetPass);
            this.Controls.Add(this.response);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.question);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "forgotpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgotpassword";
            this.Load += new System.EventHandler(this.forgotpassword_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button GetPass;
        private Guna.UI2.WinForms.Guna2TextBox response;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox question;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}