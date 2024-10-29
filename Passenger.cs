using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    public class Passenger : PersonBase
    {
        private double pesoEquipaje;
        public Passenger(int id, string name, string lastName, string document, double pesoEquipaje) : base(id, name, lastName, document)
        {
            this.pesoEquipaje = pesoEquipaje;
        }
        public double PesoEquipaje
        {
            get { return pesoEquipaje; }
            set { pesoEquipaje = value; }
        }
    }
    
}
