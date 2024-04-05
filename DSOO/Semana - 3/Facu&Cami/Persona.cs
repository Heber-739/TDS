using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu_Cami
{
    internal class Persona
    {
        string nombre;
        Domicilio domicilio;
        private Televisor tv;

        public Persona(string nombre, Domicilio domicilio)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }

        public Televisor Tv { get { return tv; } set { tv = value; } }
           

    }
}
