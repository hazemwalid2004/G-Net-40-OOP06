using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP06
{
    internal static class Recieting
    {
        public static void receipt(this Ticket ticket)
        {
            Console.WriteLine("--- Extension Method: Receipt ---");
            Console.WriteLine("========== RECEIPT ==========");
            Console.WriteLine($"Movie    : {ticket.MovieName}");
            Console.WriteLine($"Type     : {ticket.GetType().Name}");
            Console.WriteLine($"Price    : {ticket.price}");
            Console.WriteLine($"Final    : {ticket.PriceAfterTax()}");
            Console.WriteLine($"Status   : {(ticket.isbooked ? "booked" : "Not booked")}");
        }
        public static void TotalRevenue(this Ticket[] tickets)
        {
            decimal totalRevenue = 0;
            foreach (Ticket ticket in tickets)
            {
                totalRevenue += ticket.PriceAfterTax();
            }
            Console.WriteLine("--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {totalRevenue}");
        }
    }
}
