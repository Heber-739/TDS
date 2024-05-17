namespace Data_collection
{
    partial class AddActivityToPartner
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
            txtPartnerId = new TextBox();
            lblPartnerId = new Label();
            lblActivity = new Label();
            txtActivityName = new TextBox();
            lblTitle = new Label();
            btnAssign = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtPartnerId
            // 
            txtPartnerId.Location = new Point(70, 157);
            txtPartnerId.Name = "txtPartnerId";
            txtPartnerId.RightToLeft = RightToLeft.No;
            txtPartnerId.Size = new Size(281, 23);
            txtPartnerId.TabIndex = 0;
            // 
            // lblPartnerId
            // 
            lblPartnerId.AutoSize = true;
            lblPartnerId.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPartnerId.Location = new Point(35, 110);
            lblPartnerId.Name = "lblPartnerId";
            lblPartnerId.Size = new Size(147, 23);
            lblPartnerId.TabIndex = 1;
            lblPartnerId.Text = "Número de cliente:";
            // 
            // lblActivity
            // 
            lblActivity.AutoSize = true;
            lblActivity.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivity.Location = new Point(35, 221);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new Size(86, 23);
            lblActivity.TabIndex = 3;
            lblActivity.Text = "Actividad:";
            // 
            // txtActivityName
            // 
            txtActivityName.Location = new Point(70, 268);
            txtActivityName.Name = "txtActivityName";
            txtActivityName.Size = new Size(281, 23);
            txtActivityName.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(116, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(188, 30);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Asignar actividad";
            // 
            // btnAssign
            // 
            btnAssign.BackColor = SystemColors.HotTrack;
            btnAssign.Cursor = Cursors.Hand;
            btnAssign.FlatAppearance.BorderColor = Color.Black;
            btnAssign.FlatStyle = FlatStyle.Popup;
            btnAssign.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssign.ForeColor = SystemColors.ButtonFace;
            btnAssign.Location = new Point(102, 365);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(217, 52);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "AGREGAR";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssign_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.HotTrack;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.Black;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Image = Properties.Resources.search1;
            btnSearch.Location = new Point(370, 149);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(38, 31);
            btnSearch.TabIndex = 6;
            btnSearch.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // AddActivityToPartner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 450);
            Controls.Add(btnSearch);
            Controls.Add(btnAssign);
            Controls.Add(lblTitle);
            Controls.Add(lblActivity);
            Controls.Add(txtActivityName);
            Controls.Add(lblPartnerId);
            Controls.Add(txtPartnerId);
            Cursor = Cursors.Hand;
            Name = "AddActivityToPartner";
            Text = "Form1";
            FormClosing += AddActivityToPartner_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPartnerId;
        private Label lblPartnerId;
        private Label lblActivity;
        private TextBox txtActivityName;
        private Label lblTitle;
        private Button btnAssign;
        private Button btnSearch;
    }
}