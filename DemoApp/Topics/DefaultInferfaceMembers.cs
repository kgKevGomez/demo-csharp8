using System;

namespace DemoApp.Topics
{
    public interface ICustomer
    {
        DateTime DateJoined { get; }
        string Name { get; }
        
        /*// 1. Default implementation
        public decimal GetLoyaltyDiscount() => 0;
        */
        
        /*// 3. Go beyond avoid a breaking change and actually provide functionality
        private static decimal _defaultDiscountPercent = 0.10m;
        public decimal GetLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
        protected static decimal DefaultLoyaltyDiscount(ICustomer customer)
        {
            if ((DateTime.Now - customer.DateJoined).Days > 100)
            {
                return _defaultDiscountPercent;
            }
            
            return 0;
        }
        */
    }

    public class CoolblueCustomer : ICustomer
    {
        public CoolblueCustomer(string name, DateTime dateJoined)
        {
            DateJoined = dateJoined;
            Name = name;
        }

        public DateTime DateJoined { get; }
        public string Name { get; }

        /*//4. Override default implementation
        public decimal GetLoyaltyDiscount()
        {
            return 0.10m;
            
            // 5. Use default implementation
            // if (DateJoined.Year < 1980)
            //     return 0.05m;
            //
            //return ICustomer.DefaultLoyaltyDiscount(this);
        }
        */
    }

    public static class DemoClass
    {
        public static void Execute()
        {
            CoolblueCustomer customer;
            customer = new CoolblueCustomer("Juan Perez", DateTime.Now.AddYears(1993));
            
            /*//2. Implementation is not inherited
            var discount = customer.GetLoyaltyDiscount();
            */
        }
    }
}