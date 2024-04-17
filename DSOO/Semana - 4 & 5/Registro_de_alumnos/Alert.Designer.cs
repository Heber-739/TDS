namespace Registro_de_alumnos
{
    partial class Alert
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
            btnAccept = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.BackColor = SystemColors.Highlight;
            btnAccept.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccept.ForeColor = SystemColors.MenuBar;
            btnAccept.Location = new Point(77, 100);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(157, 44);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "ACEPTAR";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += button1_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(49, 45);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 1;
            // 
            // Alert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 203);
            Controls.Add(lblMessage);
            Controls.Add(btnAccept);
            Name = "Alert";
            Text = "Alert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private Label lblMessage;
    }
}