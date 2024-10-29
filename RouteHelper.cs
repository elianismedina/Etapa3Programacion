using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    internal class RouteHelper
    {
        static List<Route> Routes = new List<Route>();
        //Metodos
        public static void AñadirRuta()
        {
            Console.WriteLine("Ingrese el nombre de la ruta");
            string routeName = Console.ReadLine();
            Console.WriteLine("Ingrese el origen de la ruta");
            string origin = Console.ReadLine();
            Console.WriteLine("Ingrese el destino de la ruta");
            string destination = Console.ReadLine();
            Console.WriteLine("Ingrese la distancia de la ruta");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la duración de la ruta");
            double duration = double.Parse(Console.ReadLine());

            int id = GenerateId();

            Route route = new Route(id, routeName, origin, destination, distance, duration);


            Routes.Add(route);
            Console.WriteLine("Ruta añadida exitosamente");
        }
        public static void VerRuta()
        {
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+-------------+");
            Console.WriteLine("|      ID     |   NOMBRE    |   ORIGEN    |  DESTINO    |  DISTANCIA  |  DURACIÓN   |");
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+-------------+");
            foreach (Route route in Routes)
            {
                Console.WriteLine($"|{route.Id.ToString().PadRight(13)}|{route.RouteName.PadRight(13)}|{route.Origin.PadRight(13)}|{route.Destination.PadRight(13)}|{route.Distance.ToString().PadRight(13)}|{route.Duration.ToString().PadRight(13)}|");

            }

        }
        public static void ModificarRuta()
        {
            Console.WriteLine("Ingrese el ID de la ruta a modificar");
            int id = int.Parse(Console.ReadLine());
            Route route = Routes.FirstOrDefault(r => r.Id == id);
            Console.WriteLine("Ingrese el nombre de la ruta");
            route.RouteName = Console.ReadLine();
            Console.WriteLine("Ingrese el origen de la ruta");
            route.Origin = Console.ReadLine();
            Console.WriteLine("Ingrese el destino de la ruta");
            route.Destination = Console.ReadLine();
            Console.WriteLine("Ingrese la distancia de la ruta");
            route.Distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la duración de la ruta");
            route.Duration = double.Parse(Console.ReadLine());
            Console.WriteLine("Ruta modificada exitosamente");

        }
        public static void RemoverRuta()
        {
            
        }
        private static int GenerateId()
        {
            return Routes.Count > 0 ? Routes.Max(r => r.Id) + 1 : 1;
        }
        public static Route GetRoute()
        {
            Console.WriteLine("Ingrese el ID de la ruta");
            int id = int.Parse(Console.ReadLine());
            return Routes.FirstOrDefault(r => r.Id == id);
        }
    }
}
