using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }        
    }
    public class OrderRepository
    {
        private List<Order> _order = new List<Order>();
        public void SaveToDatabase(Order order)
        {
            Console.WriteLine("Saving order to database...");
            _order.Add(order);
        }

        public Order LoadFromDatabase(int orderId)
        {
            Console.WriteLine("Loading order from database...");
            return _order[orderId];
        }
    }
    public interface IOrderProcessPayment
    {
        void ProcessPayment();
    }
    public class OrderCreditCardPayment : IOrderProcessPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
    public class OrderPayPalPayment : IOrderProcessPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }
    public class OrderBankTransferPayment : IOrderProcessPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing bank transfer payment...");
        }
    }

}
