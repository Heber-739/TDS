namespace Data_collection
{
    partial class ClubDeportivo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picLogo = new PictureBox();
            btnNewPartner = new Button();
            btnAddActivity = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(39, 6);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(217, 192);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnNewPartner
            // 
            btnNewPartner.BackColor = SystemColors.HotTrack;
            btnNewPartner.Cursor = Cursors.Hand;
            btnNewPartner.FlatAppearance.BorderColor = Color.Black;
            btnNewPartner.FlatStyle = FlatStyle.Popup;
            btnNewPartner.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewPartner.ForeColor = SystemColors.ButtonFace;
            btnNewPartner.Location = new Point(39, 283);
            btnNewPartner.Name = "btnNewPartner";
            btnNewPartner.Size = new Size(217, 52);
            btnNewPartner.TabIndex = 1;
            btnNewPartner.Text = "ALTA SOCIO";
            btnNewPartner.UseVisualStyleBackColor = false;
            btnNewPartner.Click += btnNewPartner_Click;
            // 
            // btnAddActivity
            // 
            btnAddActivity.BackColor = SystemColors.HotTrack;
            btnAddActivity.Cursor = Cursors.Hand;
            btnAddActivity.FlatAppearance.BorderColor = Color.Black;
            btnAddActivity.FlatStyle = FlatStyle.Popup;
            btnAddActivity.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddActivity.ForeColor = SystemColors.ButtonFace;
            btnAddActivity.Location = new Point(39, 388);
            btnAddActivity.Name = "btnAddActivity";
            btnAddActivity.Size = new Size(217, 52);
            btnAddActivity.TabIndex = 2;
            btnAddActivity.Text = "ASIGNAR ACTIVIDAD";
            btnAddActivity.UseVisualStyleBackColor = false;
            btnAddActivity.Click += btnAddActivity_Click;
            // 
            // ClubDeportivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 493);
            Controls.Add(btnAddActivity);
            Controls.Add(btnNewPartner);
            Controls.Add(picLogo);
            Name = "ClubDeportivo";
            Text = "Administración";
            FormClosing += ClubDeportivo_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLogo;
        private Button btnNewPartner;
        private Button btnAddActivity;

        public void inscribirActividad()
        {

        }
    }
}
