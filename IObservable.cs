using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeObserver
{
    internal interface IObservable
    {
        // добавление наблюдателя
        void AddObserver(IObserver o);
        // удаление наблюдателя
        void RemoveObserver(IObserver o);
        // оповещение наблюдателя
        void NotifyObservers();
    }
}
