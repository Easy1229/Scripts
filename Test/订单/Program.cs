using System;
using System.Collections.Generic;

namespace 订单
{
    class OrderForm
    {
        public string name;
        public int num;
        public float price;

        public OrderForm(string name, int num, float price)
        {
            this.name = name;
            this.num = num;
            this.price = price;
        }

        public virtual float GetPrice()
        {
            return num * price;
        }
    }

    class AccountBook
    {
        private List<OrderForm> orders = new List<OrderForm>();

        public void AddOrderForm(OrderForm o)
        {
            orders.Add(o);
        }

        public virtual float GetTotalPrice()
        {
            float sum = 0;
            foreach (var o in orders)
            {
                sum += o.GetPrice();
            }
            return sum;
        }
    }

    class DiscountOrder:OrderForm
    {
        public float discount;

        public DiscountOrder(string name, int num, float price, float discount) :
            base(name, num, price)
        {
            this.discount = discount;
        }

        public override float GetPrice()
        {
            return num * price * discount;
        }
    }

    class FullCut:OrderForm
    {
        public int full;
        public int cut;

        public FullCut(string name, int num, float price,int full,int cut) :
            base(name, num, price)
        {
            this.full= full;
            this.cut = cut;
        }
        public override float GetPrice()
        {
            float sub = num * price;
            if (sub > full)
            {
                sub -= cut;
            }
            return sub;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            OrderForm o1 = new DiscountOrder("苹果",2,0.5f,0.8f);
            OrderForm o2 = new FullCut("西瓜",3,0.8f,2,1);

            AccountBook accountBook = new AccountBook();
            accountBook.AddOrderForm(o1);
            accountBook.AddOrderForm(o2);
            Console.WriteLine($"总价={accountBook.GetTotalPrice()}");
        }
    }
}