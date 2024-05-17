namespace Data_collection
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            lblTitle = new Label();
            lblPassword = new Label();
            txtActivityName = new TextBox();
            lblUsername = new Label();
            txtPartnerId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(29, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(423, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(217, 52);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(435, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(171, 30);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Inicio de sesión";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(315, 178);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Contraseña";
            // 
            // txtActivityName
            // 
            txtActivityName.Location = new Point(435, 178);
            txtActivityName.Name = "txtActivityName";
            txtActivityName.Size = new Size(301, 23);
            txtActivityName.TabIndex = 8;
            txtActivityName.TextAlign = HorizontalAlignment.Center;
            txtActivityName.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(327, 113);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 23);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Usuario";
            // 
            // txtPartnerId
            // 
            txtPartnerId.Location = new Point(435, 113);
            txtPartnerId.Name = "txtPartnerId";
            txtPartnerId.RightToLeft = RightToLeft.No;
            txtPartnerId.Size = new Size(301, 23);
            txtPartnerId.TabIndex = 6;
            txtPartnerId.TextAlign = HorizontalAlignment.Center;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(lblPassword);
            Controls.Add(txtActivityName);
            Controls.Add(lblUsername);
            Controls.Add(txtPartnerId);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label lblTitle;
        private Label lblPassword;
        private TextBox txtActivityName;
        private Label lblUsername;
        private TextBox txtPartnerId;
    }
}