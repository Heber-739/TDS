namespace Registro_de_alumnos
{
    partial class Form_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            picLogo = new PictureBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            lblName = new Label();
            lblPass = new Label();
            txtName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(308, 310);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(417, 118);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 21);
            lblName.TabIndex = 1;
            lblName.Text = "NOMBRE";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPass.Location = new Point(399, 170);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(111, 21);
            lblPass.TabIndex = 2;
            lblPass.Text = "CONTRASEÑA";
            // 
            // txtName
            // 
            txtName.ForeColor = SystemColors.WindowText;
            txtName.Location = new Point(556, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 23);
            txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(556, 169);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(270, 23);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(506, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 62);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(368, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 37);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "INICIAR SESION";
            // 
            // Form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 364);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(lblPass);
            Controls.Add(lblName);
            Controls.Add(picLogo);
            Name = "Form_login";
            Text = "Form_login";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label lblName;
        private Label lblPass;
        private TextBox txtName;
        private TextBox txtPass;
        private Button btnLogin;
        private Label lblTitle;
    }
}