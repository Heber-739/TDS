using System.Configuration;
using System.Text.Json;
using System.Text.Json.Serialization;
using Data_collection.clases;
using Newtonsoft.Json;

namespace Data_collection
{
    public partial class ClubDeportivo : Form
    {

        private List<Socio> socios = new List<Socio>();


        public ClubDeportivo()
        {
            InitializeComponent();

            var jsonFile = File.ReadAllText("Socios.json");
            List<Socio>? readSocios = JsonConvert.DeserializeObject<List<Socio>>(jsonFile, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            });
            this.socios = readSocios != null ? readSocios : new List<Socio>();

        }

        private void btnNewPartner_Click(object sender, EventArgs e)
        {
            NewClient newClient = new(this.socios);
            newClient.ShowDialog();
            if (newClient.getNewSocio() != null)
            {
                this.socios.Add(newClient.getNewSocio());
            }
        }


        private void ClubDeportivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter r = File.CreateText("Socios.json"))
            {


                string jsonWrite = JsonConvert.SerializeObject(this.socios, new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                });
                r.Write(jsonWrite);
            }
        }

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityToPartner newAssign = new(this.socios);
            newAssign.ShowDialog();
        }
    }
}
