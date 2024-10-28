using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    internal class DriverHelper
    {
        static List<Driver> Drivers = new List<Driver>();
        //Metodos
        public static void AñadirConductor()
        {
            Console.WriteLine("Ingrese el nombre del conductor");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del conductor");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese el documento conductor (C.C)");
            string document = Console.ReadLine();
            Console.WriteLine("Ingrese la licencia del conductor");
            string license = Console.ReadLine();

            int id = GenerateId();

            var driver = new Driver(id, name, lastName, document, license);

            Drivers.Add(driver);
            Console.WriteLine("Conductor añadido exitosamente");
        }
        public static void VerConductor()
        {
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");
            Console.WriteLine("|      ID     |   NOMBRE    |  APELLIDO   |  DOCUMENTO  |  LICENCIA   |");
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");
            foreach (Driver driver in Drivers)
            {
                Console.WriteLine($"|{driver.Id.ToString().PadRight(13)}|{driver.Name.PadRight(13)}|{driver.LastName.PadRight(13)}|{driver.Document.PadRight(13)}|{driver.License.PadRight(13)}|");
            }
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");

        }
        public static void ModificarConductor() {
            Console.WriteLine("Ingrese el ID del conductor a modificar");
            int id = int.Parse(Console.ReadLine());
            Driver driver = Drivers.FirstOrDefault(d => d.Id == id);

            if (driver == null)
            {
                Console.WriteLine("Conductor no encontrado");
                return;
            }
            Console.WriteLine("Ingrese el nombre del conductor");
            driver.Name = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del conductor");
            driver.LastName = Console.ReadLine();
            Console.WriteLine("Ingrese el documento conductor (C.C)");
            driver.Document = Console.ReadLine();
            Console.WriteLine("Ingrese la licencia del conductor");
            driver.License = Console.ReadLine();

            driver.Name = driver.Name;
            driver.LastName = driver.LastName;
            driver.Document = driver.Document;
            driver.License = driver.License;

            Console.WriteLine("Conductor modificado exitosamente");
        }
        public static void RemoverConductor() {
        
            Console.WriteLine("Ingrese el ID del conductor a remover");
            int id = int.Parse(Console.ReadLine());
            Driver driver = Drivers.FirstOrDefault(d => d.Id == id);

            if (driver == null)
            {
                Console.WriteLine("Conductor no encontrado");
                return;
            }
            Drivers.Remove(driver);
            Console.WriteLine("Conductor removido exitosamente");

        }

        private static int GenerateId()
        {
            return Drivers.Count > 0 ? Drivers.Max(d => d.Id) + 1 : 1;
        }
    }
}
