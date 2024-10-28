using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    internal class VehiculoHelper
    {   
        static List<Vehicle> Vehicles = new List<Vehicle>();
        //Metodos
        public static void AñadirVehiculo()
        {
            Console.WriteLine("Ingrese la placa del vehiculo");
            string licensePlate = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del vehiculo");
            string brand = Console.ReadLine();
            Console.WriteLine("Ingrese la linea del vehiculo");
            string line = Console.ReadLine();
            Console.WriteLine("Ingrese el modelo del vehiculo");
            string model = Console.ReadLine();
            Console.WriteLine("Ingrese el color del vehiculo");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese la capacidad del vehiculo");
            int capacity = int.Parse(Console.ReadLine());


            int id = GenerateId();

            var vehicle = new Vehicle(id, licensePlate, brand,line, model, color, capacity);

            Vehicles.Add(vehicle);
            Console.WriteLine("Vehiculo añadido exitosamente");
        }
        public static void VerVehiculo()
        {
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+-------------+-------------+");
            Console.WriteLine("|      ID     |   PLACA     |   MARCA     |    LÍNEA    |    MODELO   |    COLOR    |  CAPACIDAD  |");
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+-------------+-------------+");
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine($"|{vehicle.Id.ToString().PadRight(13)}|{vehicle.LicensePlate.PadRight(13)}|{vehicle.Brand.PadRight(13)}|{vehicle.Line.PadRight(13)}|{vehicle.Model.PadRight(13)}|{vehicle.Color.PadRight(13)}|{vehicle.Capacity.ToString().PadRight(13)}|");
            }
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+-------------+-------------+");


        }
        public static void ModificarVehiculo()
        {
           
           
        }
        public static void RemoverVehiculo()
        {
           
        }
        private static int GenerateId()
        {
            return Vehicles.Count > 0 ? Vehicles.Max(x => x.Id) + 1 : 1;
        }
    }
}
