namespace Registro_de_alumnos
{
    partial class Register
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblName = new Label();
            lblLastName = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtNumber = new TextBox();
            lblType = new Label();
            lblNumber = new Label();
            btnIn = new Button();
            btnCancel = new Button();
            cboType = new ComboBox();
            dtgvPostulant = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            ColumnNumner = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvPostulant).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(46, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 15);
            lblName.TabIndex = 0;
            lblName.Text = "NOMBRE";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(44, 106);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "APELLIDO";
            // 
            // txtName
            // 
            txtName.Location = new Point(136, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(323, 23);
            txtName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(136, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(323, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(418, 178);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(281, 23);
            txtNumber.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(58, 182);
            lblType.Name = "lblType";
            lblType.Size = new Size(32, 15);
            lblType.TabIndex = 5;
            lblType.Text = "TIPO";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(338, 182);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(57, 15);
            lblNumber.TabIndex = 6;
            lblNumber.Text = "NUMERO";
            // 
            // btnIn
            // 
            btnIn.Location = new Point(568, 13);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(131, 46);
            btnIn.TabIndex = 7;
            btnIn.Text = "INGRESAR";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(568, 89);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 46);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Items.AddRange(new object[] { "DNI", "PASAPORTE", "EXTRANJERO" });
            cboType.Location = new Point(136, 178);
            cboType.Name = "cboType";
            cboType.Size = new Size(154, 23);
            cboType.TabIndex = 9;
            // 
            // dtgvPostulant
            // 
            dtgvPostulant.AllowUserToAddRows = false;
            dtgvPostulant.AllowUserToDeleteRows = false;
            dtgvPostulant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvPostulant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvPostulant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPostulant.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLastName, ColumnType, ColumnNumner });
            dtgvPostulant.Location = new Point(16, 251);
            dtgvPostulant.MultiSelect = false;
            dtgvPostulant.Name = "dtgvPostulant";
            dtgvPostulant.ReadOnly = true;
            dtgvPostulant.RowTemplate.Height = 25;
            dtgvPostulant.RowTemplate.Resizable = DataGridViewTriState.True;
            dtgvPostulant.ScrollBars = ScrollBars.Horizontal;
            dtgvPostulant.Size = new Size(769, 186);
            dtgvPostulant.TabIndex = 10;
            dtgvPostulant.RowHeaderMouseDoubleClick += dtgvPostulant_RowHeaderMouseDoubleClick;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnLastName
            // 
            ColumnLastName.HeaderText = "Apellido";
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.ReadOnly = true;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Tipo identidad";
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            // 
            // ColumnNumner
            // 
            ColumnNumner.HeaderText = "Numero";
            ColumnNumner.Name = "ColumnNumner";
            ColumnNumner.ReadOnly = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvPostulant);
            Controls.Add(cboType);
            Controls.Add(btnCancel);
            Controls.Add(btnIn);
            Controls.Add(lblNumber);
            Controls.Add(lblType);
            Controls.Add(txtNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Name = "Register";
            Text = "Registro de alumnos";
            FormClosed += Register_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dtgvPostulant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtNumber;
        private Label lblType;
        private Label lblNumber;
        private Button btnIn;
        private Button btnCancel;
        private ComboBox cboType;
        private DataGridView dtgvPostulant;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn ColumnNumner;
    }
}
