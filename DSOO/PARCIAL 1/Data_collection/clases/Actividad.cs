using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Data_collection.clases
{
    public class Actividad
    {
        [JsonProperty]
        protected List<ActivityPartner> socios = new();
        public string nombre;
        public string fecha;
        public string profesor;
        [JsonProperty]
        protected int cupo;

        public Actividad(string nombre, string fecha, string profesor, int cupo) {
            this.fecha = fecha;
            this.profesor = profesor;
            this.nombre = nombre;
            this.cupo = cupo;
        }

        public bool addSocio(Socio socio)
        {

            bool alreadyInscript = this.socios.Exists(s => s.Id == socio.GetClientId());
            if(this.cupo == 0)
            {
                MessageBox.Show("Cupo para esta actividad alcanzado!");
                return false;
            } else if (alreadyInscript)
            {
                MessageBox.Show("Usuario ya inscripto");
                return false;
            } else
            {
                this.socios.Add(new ActivityPartner(socio.GetClientId(), socio.names));
                this.cupo--;
                return true;
            }
            
        }
    }
}
