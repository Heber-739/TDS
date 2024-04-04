namespace SocietyBook
{
    partial class Form1
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
            addButton = new Button();
            nameInput = new TextBox();
            lblName = new Label();
            lblAmount = new Label();
            amountInput = new NumericUpDown();
            saveButton = new Button();
            partnersList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(134, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(200, 45);
            addButton.TabIndex = 0;
            addButton.Text = "Agregar nuevo socio";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // nameInput
            // 
            nameInput.Enabled = false;
            nameInput.Location = new Point(52, 140);
            nameInput.Multiline = true;
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(364, 26);
            nameInput.TabIndex = 2;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 107);
            lblName.Name = "lblName";
            lblName.Size = new Size(108, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nombre completo:";
            lblName.Click += label1_Click;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(12, 214);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(98, 15);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Capital aportado:";
            // 
            // amountInput
            // 
            amountInput.DecimalPlaces = 2;
            amountInput.Enabled = false;
            amountInput.Location = new Point(174, 247);
            amountInput.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(120, 23);
            amountInput.TabIndex = 6;
            amountInput.TextAlign = HorizontalAlignment.Center;
            amountInput.ValueChanged += amountInput_ValueChanged;
            // 
            // saveButton
            // 
            saveButton.Enabled = false;
            saveButton.Location = new Point(134, 368);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(200, 45);
            saveButton.TabIndex = 7;
            saveButton.Text = "Guardar socio";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click_1;
            // 
            // partnersList
            // 
            partnersList.Enabled = false;
            partnersList.ForeColor = Color.Black;
            partnersList.FormattingEnabled = true;
            partnersList.ItemHeight = 15;
            partnersList.Location = new Point(440, 12);
            partnersList.Name = "partnersList";
            partnersList.RightToLeft = RightToLeft.No;
            partnersList.Size = new Size(362, 424);
            partnersList.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(partnersList);
            Controls.Add(saveButton);
            Controls.Add(amountInput);
            Controls.Add(lblAmount);
            Controls.Add(lblName);
            Controls.Add(nameInput);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private TextBox nameInput;
        private Label lblName;
        private Label lblAmount;
        private NumericUpDown amountInput;
        private Button saveButton;

        private List<Partner> partners = new List<Partner>();

        private ListBox partnersList;
    }
}
