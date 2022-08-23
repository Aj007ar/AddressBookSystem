using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC1_CreateContact
    {       
        public void CreateContact()
        {
            Console.WriteLine("Enter Full Name:");
            var full_name = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            var address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            var city = Console.ReadLine();

            Console.WriteLine("Enter State:");
            var state = Console.ReadLine();

            Console.WriteLine("Enter Zip code:");
            var zip = Console.ReadLine();

            Console.WriteLine("Enter phone Number:");
            var phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            var email = Console.ReadLine();
        }
    }
}
