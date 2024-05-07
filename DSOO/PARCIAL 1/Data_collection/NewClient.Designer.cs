using Data_collection.clases;
using Microsoft.VisualBasic;

namespace Data_collection
{
    partial class NewClient
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
            btnAssign = new Button();
            lblTitle = new Label();
            lblBirthday = new Label();
            lblNames = new Label();
            txtNames = new TextBox();
            dtpDate = new DateTimePicker();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblIsPartner = new Label();
            cboTypeClient = new ComboBox();
            lblHasAptitude = new Label();
            cboHasAptitude = new ComboBox();
            SuspendLayout();
            // 
            // btnAssign
            // 
            btnAssign.BackColor = SystemColors.HotTrack;
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderColor = Color.Black;
            btnAssign.FlatStyle = FlatStyle.Popup;
            btnAssign.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssign.ForeColor = SystemColors.ButtonFace;
            btnAssign.Location = new Point(292, 294);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(217, 52);
            btnAssign.TabIndex = 11;
            btnAssign.Text = "AGREGAR";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(323, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 30);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Registrar cliente";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthday.Location = new Point(403, 146);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(138, 23);
            lblBirthday.TabIndex = 9;
            lblBirthday.Text = "Fecha nacimiento:";
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNames.Location = new Point(32, 82);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(142, 23);
            lblNames.TabIndex = 7;
            lblNames.Text = "Nombre completo:";
            // 
            // txtNames
            // 
            txtNames.Location = new Point(174, 82);
            txtNames.Name = "txtNames";
            txtNames.RightToLeft = RightToLeft.No;
            txtNames.Size = new Size(342, 23);
            txtNames.TabIndex = 6;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(548, 144);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(111, 26);
            dtpDate.TabIndex = 12;
            dtpDate.Value = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(32, 146);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(283, 23);
            txtEmail.TabIndex = 13;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(539, 82);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(49, 23);
            lblDni.TabIndex = 16;
            lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(599, 82);
            txtDni.Name = "txtDni";
            txtDni.RightToLeft = RightToLeft.No;
            txtDni.Size = new Size(156, 23);
            txtDni.TabIndex = 15;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // lblIsPartner
            // 
            lblIsPartner.AutoSize = true;
            lblIsPartner.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsPartner.Location = new Point(32, 210);
            lblIsPartner.Name = "lblIsPartner";
            lblIsPartner.Size = new Size(102, 23);
            lblIsPartner.TabIndex = 17;
            lblIsPartner.Text = "Tipo cliente:";
            // 
            // cboTypeClient
            // 
            cboTypeClient.FormattingEnabled = true;
            cboTypeClient.Items.AddRange(new object[] { "Socio", "No Socio" });
            cboTypeClient.Location = new Point(140, 211);
            cboTypeClient.Name = "cboTypeClient";
            cboTypeClient.Size = new Size(104, 23);
            cboTypeClient.TabIndex = 18;
            // 
            // lblHasAptitude
            // 
            lblHasAptitude.AutoSize = true;
            lblHasAptitude.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasAptitude.Location = new Point(295, 208);
            lblHasAptitude.Name = "lblHasAptitude";
            lblHasAptitude.Size = new Size(91, 23);
            lblHasAptitude.TabIndex = 19;
            lblHasAptitude.Text = "Apt Fisica:";
            // 
            // cboHasAptitude
            // 
            cboHasAptitude.FormattingEnabled = true;
            cboHasAptitude.Items.AddRange(new object[] { "Presentado", "Adeudado" });
            cboHasAptitude.Location = new Point(403, 208);
            cboHasAptitude.Name = "cboHasAptitude";
            cboHasAptitude.Size = new Size(104, 23);
            cboHasAptitude.TabIndex = 20;
            // 
            // NewClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(cboHasAptitude);
            Controls.Add(lblHasAptitude);
            Controls.Add(cboTypeClient);
            Controls.Add(lblIsPartner);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(dtpDate);
            Controls.Add(btnAssign);
            Controls.Add(lblTitle);
            Controls.Add(lblBirthday);
            Controls.Add(lblNames);
            Controls.Add(txtNames);
            Name = "NewClient";
            Text = "NewClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button btnAssign;
        private Label lblTitle;
        private Label lblBirthday;
        private Label lblNames;
        private TextBox txtNames;
        private DateTimePicker dtpDate;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblIsPartner;
        private ComboBox cboTypeClient;
        private Label lblHasAptitude;
        private ComboBox cboHasAptitude;
    }
}