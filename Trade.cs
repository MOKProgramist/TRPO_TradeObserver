using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeObserver
{
    internal class Trade : IObservable
    {
        // список наблюдателей
        private List<IObserver> observers;
        // цена
        public double Price = 1;

        public Trade()
        {
            observers = new List<IObserver>();
        }


        public void Marker()
        {
            Console.WriteLine();
            Console.WriteLine("Начинаем торги:");
            Random rnd = new Random();
            Price = rnd.Next(0, 1);
            NotifyObservers();
        }

        // добавление объекта, который наблюдает
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }
        // удаление объекта, который наблюдает
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        // оповещение объекта, который наблюдает 
        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(Price);
        }
    }
}
