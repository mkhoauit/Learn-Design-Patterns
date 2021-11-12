using LearnCommand.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearnCommand.Classes
{
    class Client 
    {
        

        private List<IOrder> orderList = new List<IOrder>();
       
        public void takeIOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {

            foreach(IOrder order in orderList)
            {
                order.execute();
            }
            orderList.Clear();
        }
    }
}
