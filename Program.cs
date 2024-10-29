//Nombre: Elianis Manuel Medina Morón
//Cédula: 1129578794
//Fecha: 28/10/2024
//Descripción: Programa que simula un sistema de transporte público, donde se pueden administrar conductores, vehículos, rutas y tiquetes.
//Grupo: 213023_218
//Programa: Ingeniería Multimedia

using Etapa3Programacion;
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        while (opcion != 7)
        {
            Console.WriteLine("Sistema de transporte público");
            Console.WriteLine("1. Administrar Conductores");
            Console.WriteLine("2. Administrar Vehículos");
            Console.WriteLine("3. Administrar Rutas");
            Console.WriteLine("4. Administrar Véhiculos");
            Console.WriteLine("5. Administrar Tiquetes");
            Console.WriteLine("6. Administrar Pasajeros");
            Console.WriteLine("7. Salir");
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
                    AdministrarTiquetes();
                    break;
                case 6:
                    AdministrarPasajeros();
                    break;
                case 7:
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

    static void AdministrarTiquetes()
    {
        int opcion = 0;
        while (opcion != 6)
        {
            Console.WriteLine("Menú Administrar Tiquetes");
            Console.WriteLine("1. Añadir tiquete");
            Console.WriteLine("2. Ver tiquetes");
            Console.WriteLine("3. Modificar tiquete");
            Console.WriteLine("4. Remover tiquete");
            Console.WriteLine("5. Vender tiquete");
            Console.WriteLine("6. Volver a Menú Principal");
            Console.Write("Ingresa una opcion(1-5): ");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    TicketHelper.AddTicket();
                    break;
                case 2:
                    TicketHelper.ShowTicket();
                    break;
                case 3:
                    TicketHelper.ModifyTicket();
                    break;
                case 4:
                    TicketHelper.DeleteTicket();
                    break;
                case 5:
                    TicketHelper.SellTicket();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo");
                    break;

            }
        }

        
    }

    static void AdministrarPasajeros()
    {
        int opcion = 0;
        while (opcion != 5)
        {
            Console.WriteLine("Menú Administrar Pasajeros");
            Console.WriteLine("1. Añadir pasajero");
            Console.WriteLine("2. Ver pasajeros");
            Console.WriteLine("3. Modificar pasajero");
            Console.WriteLine("4. Remover pasajero");
            Console.WriteLine("5. Volver a Menú Principal");
            Console.Write("Ingresa una opcion(1-5): ");

            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    PassengerHelper.AddPassenger();
                    break;
                case 2:
                    PassengerHelper.ShowPassenger();
                    break;
                case 3:
                    PassengerHelper.ModifyPassenger();
                    break;
                case 4:
                    PassengerHelper.DeletePassenger();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo");
                    break;

            }

        }
    }
}
