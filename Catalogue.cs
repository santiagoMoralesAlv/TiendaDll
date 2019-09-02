using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Catalogue
    {

        private List<StoreItem> items = new List<StoreItem>();

        public List<StoreItem> Items
        {
            get
            {
                return items;
            }
        }

        public Catalogue() {

            
        }

        
    }
}
