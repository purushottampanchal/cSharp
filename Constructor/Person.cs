using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeBase2.Constructor
{
    internal class Person
    {
        public string LastName { get; set; }    
        public string FirstName { get; set; }
        public string? Email { get; set; }
        DateOnly? DateOfBirth { get; set; }

        public Person(string lastName, string firstName, string email, DateOnly dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        public Person(string lastName, string firstName, string email)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            DateOfBirth = null;
        }

        public Person(string lastName, string firstName, DateOnly dateOfBirth)
        {
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Email = null;
        }

        public void Display()
        {
            string str2 =
                (Email != null && DateOfBirth != null) ?
                ("\nEmail: " + Email + "\nDob: " + DateOfBirth.ToString()):
                    (Email == null ? "\nDoB: " + DateOfBirth.ToString() : "\nEmail: " + Email);

            string str = "_______________________"+"\nFirst name:" + FirstName +
                "\nLast name:" + LastName +
                str2;

            Console.WriteLine(str);
        }

    }
}
