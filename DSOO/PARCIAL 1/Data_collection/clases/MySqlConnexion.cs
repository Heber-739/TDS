using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_collection.clases
{
    internal class MySqlConnexion
    {

        private static MySqlConnexion _instance;

        private static readonly object _lock = new object();

        private MySqlConnexion()
        {
            // Inicialización de recursos
        }

        public static MySqlConnexion Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new MySqlConnexion();
                        }
                    }
                }
                return _instance;
            }
        }

        public void DoWork()
        {
            Console.WriteLine("El Singleton está trabajando.");
        }


    }
}
