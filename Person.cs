using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    public abstract class PersonBase
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        protected PersonBase(int id, string name, string lastName, string document)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Document = document;
        }

        
    }
}
