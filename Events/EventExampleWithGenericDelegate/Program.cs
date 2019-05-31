using EventExampleWithGenericDelegate.Classes;
using System;

namespace EventExampleWithGenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            void Alarm()
            {
                Console.WriteLine("Attention: the product is expired!");
            }

            void BuyAProduct()
            {
                Console.WriteLine("A new product has been buyed");
            }

            void TrashTheOldProduct()
            {
                Console.WriteLine("The expired product has been trashed");
            }

            var product = new Product();
            product.Expired += Alarm;
            product.Expired += BuyAProduct;
            product.Expired += TrashTheOldProduct;

            while(true)
            {
                if(product.EvaluateExpiryDate() >= 3)
                {
                    product.Expired -= BuyAProduct;
                    product.Expired -= TrashTheOldProduct;
                }

            }
        }
    }
}
