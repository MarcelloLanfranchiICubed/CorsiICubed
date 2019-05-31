using System;

namespace EventExampleWithGenericDelegate.Classes
{
    public delegate void MyDelegate();
    public class Product
    {
        private DateTime expiryDate { get; set; }
        private int NumberOfBuyedProducts { get; set; }

        public event MyDelegate Expired;

        public Product()
        {
            ResetExpiryDate();
        }

        protected virtual void OnExpired()
        {
            MyDelegate del = Expired;
            if(del != null)
            {
                del();
            }
        }

        public int EvaluateExpiryDate()
        {
            if(DateTime.Now >= expiryDate)
            {
                OnExpired();
                IncrementNumerOfBuyedProducts();
                ResetExpiryDate();
            }
            return NumberOfBuyedProducts;
        }

        private void ResetExpiryDate()
        {
            this.expiryDate = DateTime.Now.AddSeconds(5);
        }

        private void IncrementNumerOfBuyedProducts()
        {
            this.NumberOfBuyedProducts += 1;
        }
    }
}
