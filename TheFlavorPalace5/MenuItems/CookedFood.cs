using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFlavorPalace5
{
    public class CookedFood : MenuItem
    {
        public virtual int Quantity { get; }

        public virtual void Cook() { }

        public override void Obtain() { }
        public override void Serve() { }
    }
}
