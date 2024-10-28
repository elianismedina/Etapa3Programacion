using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    public class Driver : PersonBase
    {
        int IdCounter = 0;
        private string license;
        public Driver(int id, string name, string lastName, string document, string license) : base(id, name, lastName, document)
        {
            this.license = license;


        }
        public string License
        {
            get { return license; }
            set { license = value; }
        }


    }
}
    