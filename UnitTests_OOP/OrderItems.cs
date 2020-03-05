using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_OOP
{
    class OrderItem
    {
        public OrderItem()
        {
            
        
        }

        public OrderItem(int OrderItemId)
        
        {
        OrderItemId = orderItemId;
        }

        public int OrderItemId {private set; get;}
        public int ProductId {set; get;}
        public int Quantity {set; get;}
        public decimal? PurchasePrice {set; get;}
    
        public bool Validate()
        {
        var isValid = true;

        if ( Quantity <= 0) isValid = false;
>       if ( ProductId <= 0) isValid = false;
        if ( PurchasePrice == null) isValid = false;

        return isValid;
        }

        public OrderItem Retrieve()
        {
        return new OrderItem();
        }

        public bool Save()
        {
        return true;
        
        }

    }
}
