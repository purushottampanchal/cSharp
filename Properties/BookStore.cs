using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Properties
{
    internal class BookStore
    {

        public string isbn { get; set; }
        public string BookName { get; set; }
        public string BookAuther { get; set; }
        public int QtyOfBook { get; set; }
        public int BookPrice { get; set; }

        public BookStore(string isbn, string bookName, string bookAuther, int qtyOfBook, int bookPrice)
        {
            this.isbn = isbn;
            BookName = bookName;
            BookAuther = bookAuther;
            QtyOfBook = qtyOfBook;
            BookPrice = bookPrice;
        }

        public int Calculate()
        {
            return QtyOfBook*BookPrice;
        } 

        public void Display()
        {
            string str = "***Book details***" +
                "\nisbn: " + isbn +
                "\nName: " + BookName +
                "\nAuthor: " + BookAuther +
                "\nQty: " + QtyOfBook +
                "\nPrice: " + BookPrice +
                "\nTotal Price: " + Calculate();

            Console.WriteLine(str);
        }


    }
}
