using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheFlavorPalace5
{
    internal class Server
    {
        private TableRequest _tableRequest;
        static SemaphoreSlim semaphoreServer = new SemaphoreSlim(1, 1);

        public Server()
        {
            _tableRequest = new TableRequest();
        }

        public void Receive(string name, int chickenQuantity, int eggQuantity, Drink drink)
        {
            semaphoreServer.Wait();
            for (int i = 0; i < chickenQuantity; i++)
                _tableRequest.AddRequest<ChickenOrder>(name);
            for (int i = 0;i < eggQuantity; i++)
                _tableRequest.AddRequest<EggOrder>(name);
            if (drink is Tea)
            {
                _tableRequest.AddRequest<Tea>(name);
            }
            else if (drink is Coffee)
            {
                _tableRequest.AddRequest<Coffee>(name);
            }
            else if (drink is Juice)
            {
                _tableRequest.AddRequest<Juice>(name);
            }
            semaphoreServer.Release();
        }

        public List<string> Serve()
        {
            int Chicken_quantity = 0;
            int Egg_quantity = 0;
            string drinks = "no drink";
            List<string> result = new List<string>();
            foreach (var item in _tableRequest)
            {
                foreach (var i in _tableRequest[item])
                {
                    if (i is EggOrder)
                    {
                        Egg_quantity++;
                    }
                    else if (i is ChickenOrder)
                    {
                        Chicken_quantity++;
                    }
                    else if (i is Drink)
                    {
                        drinks = i.GetType().Name;
                    }

                }
                result.Add($"Customer - {item} is served, " +
                    $"{Chicken_quantity} chicken, {Egg_quantity} egg, {drinks}.");

                Egg_quantity = 0;
                Chicken_quantity = 0;
            }
            return result;
            
        }
        public TableRequest GetTable() => _tableRequest;

    }
}
