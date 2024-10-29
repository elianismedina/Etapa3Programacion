﻿using Etapa3Programacion;
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
        

        int opcion = 0;
        while (opcion != 5) {
            Console.WriteLine("Menu Administrar Vehiculos");
            Console.WriteLine("1. Añadir Vehiculo");
            Console.WriteLine("2. Ver Vehiculo");
            Console.WriteLine("3. Modificar Vehiculo");
            Console.WriteLine("4. Remover Vehiculo");
            Console.WriteLine("5. Volver a Menú Principal");
            Console.Write("Ingresa una opcion(1-5): ");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1:
                    VehiculoHelper.AñadirVehiculo();
                    break;
                case 2:
                    VehiculoHelper.VerVehiculo();
                    break;
                case 3:
                    VehiculoHelper.ModificarVehiculo();
                    break;
                case 4:
                    VehiculoHelper.RemoverVehiculo();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo");
                    break;

            }
        }

    }


    static void AdministrarRutas()
    {
        int opcion = 0;
        while (opcion != 5)
        {
            Console.WriteLine("Menu Administrar Rutas");
            Console.WriteLine("1. Añadir Ruta");
            Console.WriteLine("2. Ver Ruta");
            Console.WriteLine("3. Modificar Ruta");
            Console.WriteLine("4. Remover Ruta");
            Console.WriteLine("5. Volver a Menú Principal");
            Console.Write("Ingresa una opcion(1-5): ");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    RouteHelper.AñadirRuta();
                    break;
                case 2:
                    RouteHelper.VerRuta();
                    break;
                case 3:
                    RouteHelper.ModificarRuta();
                    break;
                case 4:
                    RouteHelper.RemoverRuta();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo");
                    break;

            }
        }


    }

    static void VenderTiquetes()
    {
        // Implementation here
    }
}
