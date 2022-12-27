using ShoppingCartProject;
using System.Security.Cryptography.X509Certificates;

namespace Maveric.Runner
{
    public class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("***********ShoppingCart**************");

            Shopping shop1 = new Shopping();
            Shopping shop2 = new Shopping();
            Shopping shop3 = new Shopping();
            Shopping shop4 = new Shopping();


             shop1.ProductID= 1;
             shop1.Productdescr= "HP laptop";
             shop1.ProductQuantity=2;
             shop1.ProductPrice=20000.0;

            shop2.ProductID = 2;
            shop2.Productdescr = "Bags";
            shop2.ProductQuantity = 1;
            shop2.ProductPrice = 1200.0;

            shop3.ProductID = 3;
            shop3.Productdescr = "Toys";
            shop3.ProductQuantity = 3;
            shop3.ProductPrice = 200.0;

            shop4.ProductID = 4;
            shop4.Productdescr = "Bat";
            shop4.ProductQuantity = 2;
            shop4.ProductPrice = 2500.0;


            shop1.PrintItemDetails();
            Console.WriteLine("============================================");

            shop2.PrintItemDetails();
            Console.WriteLine("============================================");

            shop3.PrintItemDetails();
            Console.WriteLine("============================================");

            shop4.PrintItemDetails();
            Console.WriteLine("============================================");


            shop1.DiscountPrice();
            Console.WriteLine("---------------------------------------------");
            shop2.DiscountPrice();
            Console.WriteLine("---------------------------------------------");
            shop3.DiscountPrice();
            Console.WriteLine("---------------------------------------------");
            shop4.DiscountPrice();
            Console.WriteLine("---------------------------------------------");
        }
    }
}