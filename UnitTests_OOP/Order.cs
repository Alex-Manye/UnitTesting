using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTesting_OOP
{
    public class Order
    {   public Order()
        {

        }

        public Order(int orderId)
        {
        OrderId = orderId;
        
        }

        public int OrderId {private set; get;}       
        public DateTimeOffset? OrderDate {set; get;}

        //public string Customer {set; get;}
        //public string ShippingAdrress {set; get;}
        //public string Products {set; get;}
        //public int quantityOrdered {set; get;}


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
