using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TheFlavorPalace5
{
    public class TableRequest : IEnumerable<string>
    {
        private bool _isAccepted;
        public bool IsAccepted
        {
            get { return _isAccepted; }
            set { _isAccepted = value; }
        }
        private SortedDictionary<string, List<IMenuItem>> menuItems;

        public TableRequest()
        {
            menuItems = new SortedDictionary<string, List<IMenuItem>>();
            _isAccepted = true;
        }

        public void AddRequest<T>(string customer) where T : IMenuItem
        {
            if (menuItems.ContainsKey(customer))
                menuItems[customer].Add(Activator.CreateInstance<T>());
            else
            {
                menuItems[customer] = new List<IMenuItem>();
                menuItems[customer].Add((T)Activator.CreateInstance<T>());
            }
            
        }

        public List<IMenuItem> Get<T>() where T : IMenuItem
        {
            List<IMenuItem> order = new List<IMenuItem>();
            foreach (var item in menuItems)
            {
                foreach (var item2 in item.Value)
                {
                    if (typeof(T) == item2.GetType())
                    {
                        order.Add(item2);
                    }
                }
            }
            return order;
        }

        public List<IMenuItem> this[string name]
        {
            get
            {
                return menuItems[name];
            }
        }
        public IEnumerator<string> GetEnumerator()
        {
            return menuItems.Keys.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            menuItems.Clear();
        }
    }
}
