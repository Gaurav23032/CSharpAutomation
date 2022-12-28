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
        private int _ProductQuantity;
        public double ProductPrice;
        public double ProductDiscount;

        //  public int Quantity
        // {
        //  set()


        //} 
        // public Shopping()
        //{

        // }
        //public int Shopping(int _ProductQuantity);
       // {
        //this._ProductQuantity;
       // }
        public void DiscountPrice()
        {
            if (_ProductQuantity == 2)
            {
                double price = (ProductPrice - (ProductPrice * 10 / 100)) * _ProductQuantity;
                Console.WriteLine(price);
            }
            else if (_ProductQuantity >= 3 && _ProductQuantity <= 5)
            {
                double price = (ProductPrice - (ProductPrice * 15 / 100)) * _ProductQuantity;
                Console.WriteLine(price);
            }
            else if (_ProductQuantity > 5)
            {
                double price = (ProductPrice - (ProductPrice * 25/ 100)) * _ProductQuantity;
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
            Console.WriteLine("PRODUCTQUANTITY : " + _ProductQuantity);
            Console.WriteLine("PRODUCTPRICE : " + ProductPrice);
        }
    }
}
