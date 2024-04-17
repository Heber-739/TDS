using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Registro_de_alumnos.clases
{
    public enum DNI
    {
        DNI, PASAPORTE, EXTRANJERO
    }

    internal class Postulante 
    {

        private string name;
        private string lastName;
        private  DNI type;
        private int number;

        public Postulante(string name, string lastName, DNI dni, int number)
        {
            this.name = name;
            this.lastName = lastName;
            this.type = dni;
            this.number = number;
        }

        public string getName() {  return name; }
        public string getLastName() { return lastName; }
        public DNI getType() {  return type; }
        public int getNumber() { return number; }

        public override string ToString()
        {
            return $"{name},{lastName},{type},{number}";
        }

        public static Postulante FromString(string input)
        {
            string[] parts = input.Split(',');
            string name = parts[0];
            string lastName = parts[1];
            DNI type = (DNI) Enum.Parse(typeof(DNI), parts[2]);
            int number = int.Parse(parts[3]);

            return new Postulante(name, lastName, type, number);
        }

    }
}
