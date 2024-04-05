using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facu_Cami
{
    internal class Televisor
    {
        public string marca;
        public string modelo;
        public int inch;
        public bool status;
        public int channel;

        public Televisor(string marca, string modelo, int inch, bool status, int channel)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.inch = inch;
            this.status = status;
            CambiarCanal(channel);
        }

        public int? ObtenerCanalActual()
        {
                if (status)
                {
                    return channel;
                }
                    return null;
        }

        public bool CambiarCanal(int channel)
        {
            if (status)
            {
                bool validChannel = channel <= 150 && channel > 0;
                this.channel = validChannel ? channel : 1;
            }
            return status;
        }
        public bool CambiarCanal()
        {
                return CambiarCanal(channel++);
        }

        public bool VerPrendido()
        {
            return status;
        }
        public void cambiarEstado()
        {
            status = !status;
        }

    }
}
