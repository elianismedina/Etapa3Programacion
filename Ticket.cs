using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa3Programacion
{
    public class Ticket
    {
        public Ticket(int id, double price, DateOnly date, string seatNumber, bool isSold)
        {
            this.id = id;
            this.price = price;
            this.date = date;
            this.seatNumber = seatNumber;
            this.isSold = isSold;
        }

        private int id { get; set; }
       
        private double price { get; set; }
        private DateOnly date { get; set; }

        private string seatNumber { get; set; }

        private bool isSold = false;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateOnly Date
        {
            get { return date; }
            set { date = value; }
        }
        public string SeatNumber
        {
            get { return seatNumber; }
            set { seatNumber = value; }
        }
        public bool IsSold {
            get { return isSold; }
            set { isSold = value; }
        
        }






    }
}
