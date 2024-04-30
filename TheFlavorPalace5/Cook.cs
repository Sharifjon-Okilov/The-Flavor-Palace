using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TheFlavorPalace5
{
    internal class Cook
    {
        public string Name { get; set; }
        static SemaphoreSlim semaphoreCook = new SemaphoreSlim(2, 2);
        private bool _isAccepted;
        public bool IsAccepted
        {
            get { return _isAccepted; }
            set { _isAccepted = value; }
        }


        public void Process(TableRequest tableRequest)
        {
            _isAccepted = true;
            semaphoreCook.Wait();
            Thread.Sleep(5000);
            List<IMenuItem> chickens = tableRequest.Get<ChickenOrder>();
            foreach(IMenuItem item in chickens)
            {
                var chicken = (ChickenOrder)item;
                lock(chicken)
                {
                    chicken.CutUp();
                    chicken.Cook();
                }
            }
            List<IMenuItem> eggs = tableRequest.Get<EggOrder>();
            foreach (IMenuItem item in eggs)
            {
                var egg = (EggOrder)item;
                lock(egg)
                {
                    egg.Crack();
                    egg.DiscardShell();
                    egg.Cook();
                }
            }
            _isAccepted = false;
            semaphoreCook.Release();
        }


    }
}
