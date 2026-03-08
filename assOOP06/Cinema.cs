using assOOP06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP06
{
    internal partial class Cinema
    {
        public string CinemaName { get; set; }
        private Projector proj=new Projector();
        private Ticket[] tickets =new Ticket[20];

        public void Print()
        {
            Console.WriteLine("====All Tickets (from Cinema.Reporting)====");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] == null)
                {
                    break;
                }
                tickets[i].PrintTicket();
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========Cinema Opened========");
            proj.startprojector();
        }
        public void CloseCinema()
        {
            Console.WriteLine("========Cinema closed========");
            proj.stopprojector();
        }

      
    }
}
