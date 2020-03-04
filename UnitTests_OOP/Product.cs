using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_OOP
{
    public class Product
    { //Contructor
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        //attributes
        public int ProductId { private set; get; }
        public string ProductName { set; get; }
        public string ProductDescription { set; get; }
        public decimal? CurrentPrice { set; get; }



        //Methods

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        public Product Retrieve(int productId)
        {
        return new Product();

        }

        public bool Save()
        {

            return true;

        }

    }
}
