using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Data_collection.clases
{
    public class Socio : Cliente
    {
        
        public DateTime venc_pago;


        public Socio(string names, string birthday, string email, string dni, bool apt_fisica, DateTime venc): base(names, birthday, email, dni, apt_fisica)
        { 
            
            this.venc_pago = venc;
        }

        public override bool AddActividad(Actividad actividad)
        {
            if (this.actividades.Count < 3 && actividad.addSocio(this))
            {
                this.actividades.Add(actividad);
                return true;
            }
            MessageBox.Show("TOPE DE ACTIVIDADES ALCANZADO");
            return false;

        }

        public override string GetDni()
        {
            return dni;
        }

        public override string GetClientId()
        {
            return this.id_client;
        }
    }
}
