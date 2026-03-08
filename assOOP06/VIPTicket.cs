using assOOP06;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP06
{
    internal class VIPTicket:Ticket,ICloneable
    {
        private decimal serviesfee;
        public bool LoungeAccess { get; set; }
        public VIPTicket(string moviename, decimal pri,bool _LoungAcess):base(moviename,pri)
        {
            LoungeAccess = _LoungAcess;
            serviesfee = 50;
        }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" | VIP | Lounge : {LoungeAccess} | ServiceFee : {serviesfee} EGP");
        }

        public object Clone()
        {
            return new VIPTicket(MovieName, price, LoungeAccess);
        }

        public override decimal PriceAfterTax() => price + (price * 14 / 100);
    }
}
