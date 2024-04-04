using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyBook
{
    internal class Partner
    {
        private readonly string name;
        private int capital;
            public Partner( string name, int capital) { 
            this.name = name;
            this.capital = capital;
        }

        public int GetCapital()
        {
            return this.capital;
        }

        public string ToString(int amount)
        {
            decimal percentage = (decimal)this.capital/amount*100;
            return this.name + " - Capital: $ " + this.capital + " - " + Math.Round(percentage) + "% del total";
        }
        
    }
}
