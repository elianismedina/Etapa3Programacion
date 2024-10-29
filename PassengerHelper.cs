using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    internal class PassengerHelper
    {
        static List<Passenger> Passengers = new List<Passenger>();
        public static void AddPassenger()
        {
            
            Console.WriteLine("Ingrese el nombre del pasajero");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del pasajero");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese el documento del pasajero");
            string document = Console.ReadLine();
            Console.WriteLine("Ingrese el peso del equipaje del pasajero");
            double pesoEquipaje = double.Parse(Console.ReadLine());

            int id = GenerateId();
            Passenger passenger = new Passenger(id, name, lastName, document, pesoEquipaje);
            Passengers.Add(passenger);
        }
        public static void ShowPassenger()
        {
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");
            Console.WriteLine("|      ID     |   NOMBRE    |   APELLIDO  |  DOCUMENTO  |  PESO       |");
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");
            foreach (Passenger passenger in Passengers)
            {
                Console.WriteLine($"|{passenger.Id.ToString().PadRight(13)}|{passenger.Name.PadRight(13)}|{passenger.LastName.PadRight(13)}|{passenger.Document.PadRight(13)}|{passenger.PesoEquipaje.ToString().PadRight(13)}|");
            }
        }
        public static void ModifyPassenger()
        {
            Console.WriteLine("Ingrese el ID del pasajero a modificar");
            int id = int.Parse(Console.ReadLine());
            Passenger passenger = Passengers.FirstOrDefault(p => p.Id == id);
            Console.WriteLine("Ingrese el nombre del pasajero");
            passenger.Name = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del pasajero");
            passenger.LastName = Console.ReadLine();
            Console.WriteLine("Ingrese el documento del pasajero");
            passenger.Document = Console.ReadLine();
            Console.WriteLine("Ingrese el peso del equipaje del pasajero");
            passenger.PesoEquipaje = double.Parse(Console.ReadLine());
        }

        public static void DeletePassenger()
        {
            Console.WriteLine("Ingrese el ID del pasajero a eliminar");
            int id = int.Parse(Console.ReadLine());
            Passenger passenger = Passengers.FirstOrDefault(p => p.Id == id);
            Passengers.Remove(passenger);
        }

        private static int GenerateId()
        {
            return Passengers.Count > 0 ? Passengers.Max(p => p.Id) + 1 : 1;
        }
        public static Passenger GetPassenger()
        {
            Console.WriteLine("Ingrese el ID del pasajero");
            int id = int.Parse(Console.ReadLine());
            return Passengers.FirstOrDefault(p => p.Id == id);
        }



    }
}
