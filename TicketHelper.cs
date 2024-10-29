using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    internal class TicketHelper
    {
        static List<Ticket> Tickets = new List<Ticket>();

        public static void AddTicket()
        {
            
            Console.WriteLine("Ingrese el precio del ticket");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha del ticket (ddMMyyyy)");
            string dateString = Console.ReadLine();

            if (!DateOnly.TryParseExact(dateString, "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out DateOnly date))
            {
                Console.WriteLine("Formato de fecha no válido. Por favor, ingrese la fecha en el formato ddMMyyyy.");
                return;
            }
            Console.WriteLine("Ingrese el número de asiento del ticket");
            string seatNumber = Console.ReadLine();
            bool isSold = false;


            int id = GenerateId();

            var ticket = new Ticket(id, null, price, date, seatNumber, isSold);
            Tickets.Add(ticket);
            Console.WriteLine("Ticket añadido exitosamente");
        }
        public static void ShowTicket()
        {
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");
            Console.WriteLine("|      ID     |   PRECIO    |   FECHA     |  ASIENTO    |  VENDIDO    |");
            Console.WriteLine("+-------------+-------------+-------------+-------------+-------------+");
            foreach (Ticket ticket in Tickets)
            {
                Console.WriteLine($"|{ticket.Id.ToString().PadRight(13)}|{ticket.Price.ToString().PadRight(13)}|{ticket.Date.ToString().PadRight(13)}|{ticket.SeatNumber.PadRight(13)}|{ticket.IsSold.ToString().PadRight(13)}|");
            }
        }
        public static void ModifyTicket()
        {
            Console.WriteLine("Ingrese el ID del ticket a modificar");
            int id = int.Parse(Console.ReadLine());
            Ticket ticket = Tickets.FirstOrDefault(t => t.Id == id);
            Console.WriteLine("Ingrese el precio del ticket");
            ticket.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha del ticket");
            ticket.Date = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de asiento del ticket");
            ticket.SeatNumber = Console.ReadLine();
            Console.WriteLine("Ingrese si el ticket está vendido");
            ticket.IsSold = bool.Parse(Console.ReadLine());
        }

        public static void DeleteTicket()
        {
            Console.WriteLine("Ingrese el ID del ticket a eliminar");
            int id = int.Parse(Console.ReadLine());
            Ticket ticket = Tickets.FirstOrDefault(t => t.Id == id);
            Tickets.Remove(ticket);
        }

        public static Ticket GetTicket()
        {
            Console.WriteLine("Ingrese el ID del ticket");
            int id = int.Parse(Console.ReadLine());
            Ticket ticket = Tickets.FirstOrDefault(t => t.Id == id);
            return ticket;
        }

        private static int GenerateId()
        {
            return Tickets.Count > 0 ? Tickets.Max(t => t.Id) + 1 : 1;
        }
        public static void SellTicket()
        {   PassengerHelper.AddPassenger();

            Console.WriteLine("Ingrese el ID del ticket a vender");
            int id = int.Parse(Console.ReadLine());

            Ticket ticket = Tickets.FirstOrDefault(t => t.Id == id);

            ticket.IsSold = true;
            Console.WriteLine("Ticket vendido exitosamente");

        }









    }
}
