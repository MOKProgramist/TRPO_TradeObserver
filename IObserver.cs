using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeObserver
{
    internal interface IObserver
    {
        void Update(double newPrice);
    }
}
