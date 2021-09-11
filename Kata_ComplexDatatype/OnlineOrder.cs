using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrderSystem
{
    class OnlineOrder
    {
        public string ItemName;
        public double ItemCost;
        public string CustomerName;
        public string CustomerAddress;
        public int OrderNumber;
        public DateTime OrderDate;

        private static int _nextNumber = 1;
        

        public OnlineOrder(string item)
        {
            ItemName = item;
            OrderDate = DateTime.Now;
            OrderNumber = _nextNumber;
            _nextNumber++;
        }

        public int GetOrderNumber()
        {
            return OrderNumber;
        }

    }
}
