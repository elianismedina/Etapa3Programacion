using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    public class Route
    {
        public Route(int id, string routeName, string origin, string destination, double distance, double duration)
        {
            this.id = id;
            this.routeName = routeName;
            this.origin = origin;
            this.destination = destination;
            this.distance = distance;
            this.duration = duration;
        }

        private int id { get; set; }
        private string routeName { get; set; }
        private string origin { get; set; }
        private string destination { get; set; }
        private double distance { get; set; }

        private double duration { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string RouteName
        {
            get { return routeName; }
            set { routeName = value; }
        }
        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }


    }
}
