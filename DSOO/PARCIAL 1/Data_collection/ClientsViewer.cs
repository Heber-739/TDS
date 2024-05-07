using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_collection.clases;

namespace Data_collection
{
    public partial class ClientsViewer : Form
    {
        private readonly List<Socio> socios;
        private string userSelected;
        public ClientsViewer(List<Socio> socios)
        {
            this.socios = socios;
            InitializeComponent();
            this.loadClientes();
        }

        public string GetUserSelected() { return userSelected; }

        private void showClients(Socio socio)
        {
            int row = dgvClients.Rows.Add();
            dgvClients.Rows[row].Cells[0].Value = socio.names;
            dgvClients.Rows[row].Cells[1].Value = socio.GetDni();
            dgvClients.Rows[row].Cells[2].Value = socio.email;
            dgvClients.Rows[row].Cells[3].Value = socio.apt_fisica;
            dgvClients.Rows[row].Cells[4].Value = socio.venc_pago;
        }

        private void loadClientes()
        {
            foreach (var item in this.socios)
            {
                this.showClients(item);
            }
        }

        private void dgvClients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelected = e.RowIndex;
            this.userSelected = this.socios[rowSelected].GetClientId();
            this.Close();
        }
    }
}
