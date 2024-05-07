using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Data_collection.clases
{
    public abstract class Cliente
    {
        [JsonProperty]
        protected string id_client;
        public string names;
        public string birthday;
        public string email;
        [JsonProperty]
        protected string dni;
        public List<Actividad> actividades;
        public bool apt_fisica;


        public Cliente(string names,string birthday,string email,string dni,bool apt_fisica)
        {
            Guid uniqueId = Guid.NewGuid();
            this.id_client = uniqueId.ToString();

            this.names = names;
            this.birthday =birthday ;
            this.email =email ;
            this.dni =dni ;
            this.actividades = new List<Actividad>();
            this.apt_fisica =apt_fisica ;
    }

        public abstract bool AddActividad(Actividad actividad);
        public abstract string GetDni();
        public abstract string GetClientId();

    }
}
