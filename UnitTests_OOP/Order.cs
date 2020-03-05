using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTesting_OOP
{
    public class Order
    {   
        public Order()
        {

        }

        public Order(int orderId)
        {
        OrderId = orderId;
        OrderItems = new List<OrderItem>();
        }

        public int CustomerId {set; get;}
        public int ShippingOrderId {set; get;}
        public int OrderId {private set; get;}       
        public DateTimeOffset? OrderDate {set; get;}
        public List<OrderItem> OrderItems {set; get;}


        public override string ToString()=> $"{OrderDate.Value.Date} ({OrderId})"

        public bool Validate(){
        var isValid=true;

        if(OrderDate == null) isValid = false;
       
        return isValid;

        }

        public Order Retrieve(int orderId)
        {
         return new Order();
        }

        public bool Save()
        {    
        return true;
        }

    }
}
