using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Inheritance
{
    internal class Cot:Furniture
    {
     

        public string Type { get; set; }
        public string Capacity { get; set; }
        public int Rate { get; set; }


        public Cot(string type,
            string capacity, int rate,
            int orderId,
            DateOnly orderDate, string furnitureType, 
            int qty, int totalAmt, string paymentMethod) 
            : base(orderId, orderDate, furnitureType, qty, totalAmt, paymentMethod)
        {

            Type = type;
            Capacity = capacity;
            Rate = rate;
           /* base.OrderId = orderId;
            base.OrderDate = orderDate; 
            base.FurnitureType = furnitureType; 
            base.Qty = qty;
            base.TotalAmt = totalAmt;
            base.PaymentMethod = paymentMethod;*/
                

        }

        public string Display()
        {
            return "\nOrderID:" + base.OrderId +
                "\nOrder date: " + base.OrderDate +
                "\nFurniture type" + base.FurnitureType +
                "\nQty" + base.Qty +
                "\ntotal Amount: " + base.TotalAmt +
                "\nPayment method: " + base.PaymentMethod +
                "\nmaterial type" + Type +
                "\ncapcity: "+Capacity +
                "\nchair rate" + Rate;
        }


    }
}
