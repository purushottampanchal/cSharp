using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Inheritance
{
    internal class Furniture
    {
        /* •	OrderId
 •	OrderDate
 •	FurnitureType
 •	Qty
 •	TotalAmt
 •	PaymentMode(credit/debit card)*/

       
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }
        public String FurnitureType { get; set; }
        public int Qty { get; set; }
        public int TotalAmt { get; set; }
        public string PaymentMethod { get; set; }

        public Furniture(int orderId, DateOnly orderDate, 
            string furnitureType, int qty, int totalAmt, string paymentMethod)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            FurnitureType = furnitureType;
            Qty = qty;
            TotalAmt = totalAmt;
            PaymentMethod = paymentMethod;
        }


    }
}
