using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheFlavorPalace5
{
    public class ChickenOrder : CookedFood
    {
        public override int Quantity { get; }

        public override void Cook() { Thread.Sleep(200); }
        public void CutUp() { Thread.Sleep(200); }

        public override void Obtain() { Thread.Sleep(200); }
        public override void Serve() { Thread.Sleep(200); }

    }
}
