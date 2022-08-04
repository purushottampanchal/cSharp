
using codeBase2.Constructor;
using codeBase2.Inheritance;
using codeBase2.Properties;

class Program
{
    static void Main(string[] arg)
    {
        do
        {

            int ch;
            string s ="Select program\n" +
                "1. Inheritance\n" +
                "2. Properties\n" +
                "3. Constructor ()\n" +
                "4. Interfaces () \n " +
                "0. Exit";

            Console.WriteLine(s);
            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 0: return;
                case 1:

                    InheritanceProgram();

                    break;
                case 2:

                    Console.WriteLine("Enter The isbn of Book");
                    string isbn = Console.ReadLine();

                    Console.WriteLine("Enter Name of book");
                    string bookName = Console.ReadLine();

                    Console.WriteLine("Enter Auther of book");
                    string bookAuther = Console.ReadLine();

                    Console.WriteLine("Enter Qty of book");
                    int bookQty = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Price of Book");
                    int bookPrice = Convert.ToInt32(Console.ReadLine());

                    BookStore bookStore = new BookStore(isbn, bookName, bookAuther, bookQty, bookPrice);

                    bookStore.Display();

                    break;
                case 3:
                    string ch1;
                    do{ 
                    Console.WriteLine("***Select one***");
                    Console.WriteLine("aa. Person Program");
                    Console.WriteLine("bb. Building program");
                    Console.WriteLine("cc. Exit");
                    ch1 = Console.ReadLine();
                        switch (ch1)
                        {
                            case "aa":

                                personProgram();
                                break;
                            case "bb":

                                BuildingProgram();
                                break;


                        }
                    } while (ch1 != "cc");


                    break;
                case 4:   
                    InterfaceProgram();

                    break;

                default: Console.WriteLine("Invalid choice");
                    break;
            }


        }while (true);
    }

    private static void BuildingProgram()
    {

        Console.WriteLine("Enter type of building(flat/villa)");
        string buildingType = Console.ReadLine();
        Console.WriteLine("Enter Capacity (1/2/3/4BHK):");
        string buildingCapacity = Console.ReadLine();

        Console.WriteLine("Enter Dimensions: ");
        string Dimensions = Console.ReadLine();

        Building building;

        if (string.Equals(buildingType, "flat", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine("Enter Floor Number: ");
            int floorNo = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Date of completion:");
            string DateOfCompletion = Console.ReadLine();

            building = new Building(buildingType, buildingCapacity, Dimensions, DateOfCompletion, floorNo);
        }
        else
        {
            Console.WriteLine("Enter Dimensions of property (e.g 100x100): ");
            string propDimension= Console.ReadLine();
            Console.WriteLine("Date of completion:");
            string DateOfCompletion = Console.ReadLine();

            building = new Building(buildingType, buildingCapacity, Dimensions, DateOfCompletion, propDimension);
        }

        building.showData();
    }

    private static void personProgram()
    {
        char ch2;
        do
        {
            Console.WriteLine("a. first name, last name, email, DoB");
            Console.WriteLine("b. first name, last name, email");
            Console.WriteLine("c. first name, last name, DoB ");
            Console.WriteLine("d. Exit");
            ch2 = (char)char.Parse(Console.ReadLine());

            switch (ch2)
            {
                case 'a':
                    Console.WriteLine("Eneter first name");
                    string fname = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    string lname = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Dob");
                    string Dob = Console.ReadLine();
                    Person person = new Person(fname, lname, email, DateOnly.Parse(Dob));
                    person.Display();
                    break;

                case 'b':
                    Console.WriteLine("Eneter first name");
                    fname = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    lname = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    email = Console.ReadLine();
                    person = new Person(fname, lname, email);
                    person.Display();
                    break;

                case 'c':

                    Console.WriteLine("Eneter first name");
                    fname = Console.ReadLine();
                    Console.WriteLine("Enter Last name");
                    lname = Console.ReadLine();
                    Console.WriteLine("Enter Dob");
                    Dob = Console.ReadLine();
                    person = new Person(fname, lname, DateOnly.Parse(Dob));
                    person.Display();

                    break;


            }

        } while (ch2 == 'd');

    }

    private static void InterfaceProgram()
    {


/*        
 If class is TCS , 12% of basic salary of employee should go for PF and 8.33% of
basic salary should go for PF as employer contribution and 3.67% of Basic Amount 
should go for Pension Fund from employer contribution.
Leave Details for TCS is 
1 day of Casual Leave per month
12 days of Sick Leave per year
10 days of Previlage Leave per year
Gratuity amount : if the no of service year completed in the same company is > 5 , 1month basic salary will be deposited in gratuity amount
if >10 years service, 2*basic salary = gratuity amount
if >20 years service, 3* basic salary = gratuity amount
if < 5 no gratuity.

 */



    }

private static void InheritanceProgram()
    {
        Console.WriteLine("****Program for inheritance****");
        Console.WriteLine("Enter Following details");
        Console.WriteLine("Order ID:");
        int oid = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Order Date(dd/mm/yyyy):");
        DateOnly orderDate = DateOnly.Parse(Console.ReadLine());

        Console.WriteLine("Furniture Type(Cot/Chair)");
        string type = Console.ReadLine();

        /*while (!string.Equals(type, "COt", StringComparison.CurrentCultureIgnoreCase) ||
        !string.Equals(type, "Chair", StringComparison.CurrentCultureIgnoreCase)
        )*/
        /*while(type != "cot" || type !=  "chair")
        {
            Console.WriteLine("Furniture type must be cot or chair");
            type = Console.ReadLine();
        } ;*/

        Console.WriteLine("Qty:");
        int qty = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Total Amount");
        int TotalAmt = Convert.ToInt32(Console.ReadLine());
        string PaymentMethod;
        /*do
        {*/
        Console.WriteLine("Card type(credit/Debit)");
        PaymentMethod = Console.ReadLine();

        /*} while (string.Equals(PaymentMethod, "Credit", StringComparison.CurrentCultureIgnoreCase) ||
        string.Equals(PaymentMethod, "Debit", StringComparison.CurrentCultureIgnoreCase)
        );*/

        if (string.Equals(type, "Chair", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine("Purpose(home/office)");
            string purpose = Console.ReadLine();

            Console.WriteLine("What is Type of chair(Wood/Steel/plastic): ");
            string chairType = Console.ReadLine();

            Console.WriteLine("Chair Material: ");
            string chairMaterial = Console.ReadLine();

            Console.WriteLine("Chair Rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Chair chair = new Chair(chairMaterial, rate, oid, orderDate, type, qty, TotalAmt, PaymentMethod);
            Console.WriteLine(chair.ToString());
        }
        else if (string.Equals(type, "cot", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine("Cot Type: ");
            string cotType = Console.ReadLine();

            Console.WriteLine("Cot Capacity: ");
            string cotCapacity = Console.ReadLine();

            Console.WriteLine("Cot Rate: ");
            int cotRate = Convert.ToInt32(Console.ReadLine());

            Cot cot = new Cot(cotType, cotCapacity, cotRate, oid, orderDate, type, qty, TotalAmt, PaymentMethod);

            Console.WriteLine(cot.Display());

        }
    }
}
