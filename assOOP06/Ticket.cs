using assOOP06;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace assOOP06
{
    internal abstract class Ticket
    {
        private String moviename;
        private  decimal Price;
        private static int totalTicket = 0;
        public bool isbooked { get; set; } = false;
        public String MovieName 
        { 
            get { return moviename; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    moviename = value;
                }
            }
        }
        public decimal price
        {
            get { return Price; }
            set
            {
                if (Price > 0)
                {
                    Price = value;
                }
            }
        }
        public void SetPrice(decimal _price)
        {
            price = _price;
        }
        public void SetPrice(decimal _price,decimal multiplier)
        {
            price= _price*multiplier;
        }
        public int TicketId { get; }
        public Ticket (String _moviename,decimal _price)
        {
            MovieName = _moviename;
            Price = _price;
            totalTicket++;
            TicketId=totalTicket;
            
        }
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket # {TicketId} | {MovieName} | Price : {Price} EGP | After Tax : {PriceAfterTax()} EGP | Book : {(isbooked ? "Yes" : "No")}" );
        }


        public abstract decimal PriceAfterTax();
      
        
        public static int GetTotalTickets()
        {
            return totalTicket;
        }

        public void book()
        {
            if (isbooked) { return; }
             isbooked = true; 
        }
        public void cancel()
        {
            if (!isbooked) { return; }
             isbooked = false; 
        }
    }
}
