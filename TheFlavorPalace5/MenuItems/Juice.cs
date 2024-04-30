using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFlavorPalace5
{
    public class Juice : Drink
    {
        public override void Obtain() { }
        public override void Serve() { }

        public override string ToString()
        {
            return nameof(Juice);
        }
    }
}
