using Etapa3Programacion;
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        while (opcion != 6)
        {
            Console.WriteLine("Sistema de transporte público");
            Console.WriteLine("1. Administrar Conductores");
            Console.WriteLine("2. Administrar Véhiculos");
            Console.WriteLine("3. Administrar Rutas");
            Console.WriteLine("4. Administrar Véhiculos");
            Console.WriteLine("5. Vender Tiquetes");
            Console.WriteLine("6. Salir");
            Console.Write("Ingresa una opcion(1-6): ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AdministrarConductores();
                    break;
                case 2:
                    AdministrarVehiculos();
                    break;
                case 3:
                    AdministrarRutas();
                    break;
                case 4:
                    AdministrarVehiculos();
                    break;
                case 5:
                    VenderTiquetes();
                    break;
                case 6:
                    Console.WriteLine("Gracias por usar el sistema");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo");
                    break;
            }
        }
    }

    static void AdministrarConductores()
    {
        int opcion = 0;
        while (opcion != 5)
        {
            Console.WriteLine("Menu Administrar Conductores");
            Console.WriteLine("1. Añadir Conductor");
            Console.WriteLine("2. Ver Conductor");
            Console.WriteLine("3. Modificar Conductor");
            Console.WriteLine("4. Remover Conductor");
            Console.WriteLine("5. Volver a Menú Principal");
            Console.Write("Ingresa una opcion(1-5): ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    DriverHelper.AñadirConductor();
                    break;
                case 2:
                    DriverHelper.VerConductor();
                    break;
                case 3:
                    DriverHelper.ModificarConductor();
                    break;
                case 4:
                    DriverHelper.RemoverConductor();
                    break;
                case 5:                    
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo");
                    break;
            }
        }
    }

    static void AdministrarVehiculos()
    {
        // Implementation here
    }

    static void AdministrarRutas()
    {
        // Implementation here
    }

    static void VenderTiquetes()
    {
        // Implementation here
    }
}
