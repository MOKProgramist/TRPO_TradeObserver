using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeObserver
{
    internal class ConcreteObservable: IObservable
    {
        // список наблюдателей
        private List<IObserver> observers;
        public ConcreteObservable() {
            observers = new List<IObserver> ();
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
                observer.Update();
        }
    }
}
