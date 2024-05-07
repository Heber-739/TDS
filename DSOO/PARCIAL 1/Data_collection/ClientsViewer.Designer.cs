namespace Data_collection
{
    partial class ClientsViewer
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvClients = new DataGridView();
            socioBindingSource = new BindingSource(components);
            lblTitle = new Label();
            lblSelect = new Label();
            socioBindingSource1 = new BindingSource(components);
            colName = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAptFisica = new DataGridViewTextBoxColumn();
            colVencPago = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { colName, colDni, colEmail, colAptFisica, colVencPago });
            dgvClients.Location = new Point(12, 124);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(776, 314);
            dgvClients.TabIndex = 0;
            dgvClients.RowHeaderMouseDoubleClick += dgvClients_RowHeaderMouseDoubleClick;
            // 
            // socioBindingSource
            // 
            socioBindingSource.DataSource = typeof(clases.Socio);
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(296, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 30);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Listado de Clientes";
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(12, 106);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(153, 15);
            lblSelect.TabIndex = 12;
            lblSelect.Text = "Doble click para seleccionar";
            // 
            // socioBindingSource1
            // 
            socioBindingSource1.DataSource = typeof(clases.Socio);
            // 
            // colName
            // 
            colName.HeaderText = "Nombre";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            colDni.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAptFisica
            // 
            colAptFisica.HeaderText = "Apt Fisica";
            colAptFisica.Name = "colAptFisica";
            colAptFisica.ReadOnly = true;
            // 
            // colVencPago
            // 
            colVencPago.HeaderText = "Venc Pago";
            colVencPago.Name = "colVencPago";
            colVencPago.ReadOnly = true;
            // 
            // ClientsViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSelect);
            Controls.Add(lblTitle);
            Controls.Add(dgvClients);
            Name = "ClientsViewer";
            Text = "ClientsViewer";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClients;
        private Label lblTitle;
        private Label lblSelect;
        private BindingSource socioBindingSource;
        private BindingSource socioBindingSource1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAptFisica;
        private DataGridViewTextBoxColumn colVencPago;
    }
}