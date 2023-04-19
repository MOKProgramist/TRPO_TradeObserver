// See https://aka.ms/new-console-template for more information

// [+] создаем торговлю
// создаем покупателей
// записываем покупателей в прослушивание торговли

// мзменяем цену на торговлю
// покупатели покучают уведомление: если x > 0.5 - цена увеличилась, иначе уменьшилась
using TradeObserver;

Console.WriteLine("Hello, World!");

Trade trade = new Trade();

Customer customer1 = new Customer("Никита");
Customer customer2 = new Customer("Максим");


trade.AddObserver(customer1);
trade.AddObserver(customer2);

trade.Marker();

trade.RemoveObserver(customer1);

trade.Marker();

Console.ReadLine();