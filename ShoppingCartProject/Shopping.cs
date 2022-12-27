using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Shopping
    {
        public int ProductID;
        public string Productdescr;
        public int ProductQuantity;
        public double ProductPrice;
        public double ProductDiscount;

        public void DiscountPrice()
        {
            if (ProductQuantity == 2)
            {
                double price = (ProductPrice - (ProductPrice * 10 / 100)) * ProductQuantity;
                Console.WriteLine(price);
            }
            else if (ProductQuantity >= 3 && ProductQuantity <= 5)
            {
                double price = (ProductPrice - (ProductPrice * 10 / 100)) * ProductQuantity;
                Console.WriteLine(price);
            }
            else if (ProductQuantity > 5)
            {
                double price = (ProductPrice - (ProductPrice * 10 / 100)) * ProductQuantity;
                Console.WriteLine(price);
            }
            else 
                    {
                Console.WriteLine(" No discount");
            }
        }
        public void PrintItemDetails()
        {
            Console.WriteLine("PRODUCTID : " + ProductID);
            Console.WriteLine("PRODUCTDESCR :  " + Productdescr);
            Console.WriteLine("PRODUCTQUANTITY : " + ProductQuantity);
            Console.WriteLine("PRODUCTPRICE : " + ProductPrice);
        }
    }
}
