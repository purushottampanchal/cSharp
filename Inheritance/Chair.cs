using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Inheritance
{
    internal class Chair:Furniture
    {

        String Material { get; set; }
        public int Rate { get; set; }

        public Chair(string material, int rate, int orderId, DateOnly orderDate,
            string furnitureType, int qty, int totalAmt,
            string paymentMethod): base(orderId, orderDate, furnitureType, qty, totalAmt, paymentMethod)
        {
            this.Material = material;
            Rate = rate;

        }

        public override string ToString()
        {
            return "\nOrderID:" + base.OrderId +
                "\nOrder date: " + base.OrderDate +
                "\nFurniture type" + base.FurnitureType +
                "\nQty" + base.Qty +
                "\ntotal Amount: " + base.TotalAmt +
                "\nPayment method: " + base.PaymentMethod +
                "\nChair material" + Material +
                "\nchair rate" + Rate;
      
        }

    }
}
