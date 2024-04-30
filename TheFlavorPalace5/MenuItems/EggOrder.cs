using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheFlavorPalace5
{
    public class EggOrder : CookedFood
    {
        private int _quality;
        public override int Quantity { get; }
        public  int Quaity { get { return _quality; } }
        public EggOrder()
        {
            Random random = new Random();
            _quality = random.Next(25, 100);
        }
        public void Crack()
        {
            Thread.Sleep(200);
            if (_quality < 25)
                throw new Exception("Rotten egg");
        }
        public override void Cook() { Thread.Sleep(200); }
        public  void DiscardShell() { Thread.Sleep(200); }
        public override void Obtain() { Thread.Sleep(200); }
        public override void Serve() { Thread.Sleep(200); }

    }
}
