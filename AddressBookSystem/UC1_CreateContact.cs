using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC1_CreateContact
    {       
          public Dictionary<string, List<string>> contact = new Dictionary<string, List<string>>();

            public void Add_Contact()
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

                var details = new List<string> { address, city, state, zip, phoneNumber, email };
                contact.Add(full_name.ToUpper(), details);
            }  
    }
}
