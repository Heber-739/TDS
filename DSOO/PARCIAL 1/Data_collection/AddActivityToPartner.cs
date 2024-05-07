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
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;

namespace Data_collection
{
    public partial class AddActivityToPartner : Form
    {
        private readonly List<Socio> socios;
        private List<Actividad> actividades = new();
        public AddActivityToPartner(List<Socio> socios)
        {
            this.socios = socios;
            InitializeComponent();

            var jsonFile = File.ReadAllText("Actividades.json");
            List<Actividad>? readAct = JsonConvert.DeserializeObject<List<Actividad>>(jsonFile, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });
            this.actividades = readAct != null ? readAct : new List<Actividad>();

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

            if (txtPartnerId.Text == null || txtActivityName == null)
            {
                MessageBox.Show("No se aceptan datos vacíos!");
                return;
            }


            Socio? client = this.socios.Find(s => s.GetClientId() == txtPartnerId.Text);
            Actividad? act = this.actividades.Find(s => s.nombre.ToUpper() == txtActivityName.Text.ToUpper());

            if (client == null)
            {
                MessageBox.Show("SOCIO INEXISTENTE");
                return;
            }
            else if (act == null)
            {
                MessageBox.Show("ACTIVIDAD INEXISTENTE");
                return;
            }
            else if (client.AddActividad(act))
            {
                MessageBox.Show("INSCRIPCIÓN EXITOSA");
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClientsViewer viewer = new ClientsViewer(this.socios);
            viewer.ShowDialog();
            txtPartnerId.Text = viewer.GetUserSelected();
        }

        private void AddActivityToPartner_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter r = File.CreateText("Actividades.json"))
            {

                string jsonWrite = JsonConvert.SerializeObject(this.actividades, new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                });
                r.Write(jsonWrite);
            }
        }
    }
}
