using assOOP06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace assOOP06
{
    internal class IMAXTicket:Ticket,ICloneable
    {
        private bool Is3d;
        public IMAXTicket(string moviename, decimal pri, bool _Is3D):base(moviename,pri)
        {
            Is3d = _Is3D;
            if (Is3d)
            {
                price += 30;
            }
        }

        public object Clone()
        {
            return new IMAXTicket(MovieName,price,Is3d);
        }

        public override decimal PriceAfterTax() => price + (price * 14 / 100);

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"| IMAX | Imax 3D : {Is3d}");
        }
    }
}
