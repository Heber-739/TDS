using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_collection.clases
{
    public class ActivityPartner
    {
        public string Id { get; }
        public string Name { get;}
        public ActivityPartner(string id, string name    ) { 
        this.Id = id;
            this.Name = name;
                }
    }
}
