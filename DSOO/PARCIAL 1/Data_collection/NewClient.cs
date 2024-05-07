
using System.Net.Http.Json;
using System.Text.Json;
using Newtonsoft.Json;
using System.Xml;
using Data_collection.clases;

namespace Data_collection
{
    public partial class NewClient : Form
    {

        private readonly List<Socio> socios;

        private Socio newSocio;

        public Socio getNewSocio()
        {
            return newSocio;
        }

        public NewClient(List<Socio> socios)
        {
            InitializeComponent();
            this.socios = socios;
           
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNames.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(cboTypeClient.Text) ||
                string.IsNullOrWhiteSpace(cboHasAptitude.Text) || string.IsNullOrWhiteSpace(dtpDate.Text))
            {
                return;
            }

            altaSocio(txtNames.Text, txtDni.Text, txtEmail.Text, dtpDate.Text, cboTypeClient.Text, cboHasAptitude.Text);

        }

        private void altaSocio(string names, string dni, string email, string date, string typeClient, string hasAptitude)
        {
            if (typeClient == "Socio")
            {
                try
                {
                    bool alreadyExist = this.socios.Count > 0 && this.socios.Exists(s => s.GetDni() == dni);
                    if (!alreadyExist)
                    {
                        this.newSocio = new Socio(names, date, email, dni, hasAptitude == "Presentado", new DateTime());

                        MessageBox.Show("Socio cargado con éxito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Socio ya existente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDni.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Solo se admiten números.");
                txtDni.Text = string.Empty;
            }
        }

    }
}
