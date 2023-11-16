    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    public class Product
    {
        protected int quantity;
        protected double price;

        public Product( int quantity, double price)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public double GetTotalPrice()
        {
            return quantity * price;
        }
    }

    public class Markers : Product
    {
        protected string name;
        protected int grade;

        public Markers(string name, int quantity, double price, int grade) : base(quantity, price)
        {
            this.name = name;
            this.grade = grade;
        }

        public new double GetTotalPrice()
        {
            return base.GetTotalPrice() / grade;
        }
    }
    
}
