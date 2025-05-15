using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp.Exceptions
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string itemName)
            : base($"Item '{itemName}' not found in the cart.")
        {
        }
    }
}
