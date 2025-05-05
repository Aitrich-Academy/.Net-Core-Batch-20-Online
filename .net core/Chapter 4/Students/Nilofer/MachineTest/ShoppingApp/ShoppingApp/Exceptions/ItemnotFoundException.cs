using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Exceptions
{
    internal class ItemnotFoundException:ApplicationException
    {
        public ItemnotFoundException() { }
        public ItemnotFoundException(string message) : base(message) { }
    }
}
