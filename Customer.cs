using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeObserver
{
    internal class Customer: IObserver
    {
        private string Name;

        public Customer(string name) {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void Update(double newPrice)
        {
            if (newPrice > 0.5) Console.WriteLine($"{Name}, Покупать");
            else Console.WriteLine($"{Name}, Не покупать");
        }
    }
}
