using assOOP06;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP06
{
    internal class StandardTicket:Ticket,ICloneable
    {
        public string seatNumber { get; set; }
        public StandardTicket(string moviename,decimal pri,string _seatnumber) : base(moviename, pri)
        {
            seatNumber=_seatnumber;
        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" | standard | seat : {seatNumber}");
        }

        public object Clone()
        {
            return new StandardTicket(MovieName,price,seatNumber);
        }

        public override decimal PriceAfterTax() => price + (price * 14 / 100);
    }
}
