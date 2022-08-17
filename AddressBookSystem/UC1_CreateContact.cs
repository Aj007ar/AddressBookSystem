using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC1_CreateContact
    {       
           Dictionary<string, string> contact = new Dictionary<string, string>();

            public void Add_Contact()
            {
                Console.WriteLine("Enter First Name:");
                contact.Add("First_Name",Console.ReadLine());

                Console.WriteLine("Enter Last Name:");
                contact.Add("Last_Name", Console.ReadLine());

                Console.WriteLine("Enter Address:");
                contact.Add("Address", Console.ReadLine());

                Console.WriteLine("Enter City:");
                contact.Add("City_Name", Console.ReadLine());

                Console.WriteLine("Enter State:");
                contact.Add("State_Name", Console.ReadLine());

                Console.WriteLine("Enter Zip code:");
                contact.Add("Zip_Code", Console.ReadLine());

                Console.WriteLine("Enter phone Number:");
                contact.Add("Phone_Number", Console.ReadLine());

                Console.WriteLine("Enter Email:");
                contact.Add("Email", Console.ReadLine());
            }       
    }
}
