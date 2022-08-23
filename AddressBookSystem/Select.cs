using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Select : UC5_ViewContact
    {
        public void Check()
        {
            Console.WriteLine("1. Add contacts in address book:");
            Console.WriteLine("2.details");
            Console.WriteLine("3.View Details");
            Console.WriteLine("4.Edit Contact");
            Console.WriteLine("5.Delete contacts");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Choose option for execute a program");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Add_Contact();
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    Check();
                    break;
                case 2:
                    ContactDetails();
                    Console.WriteLine("press enter to continue");
                    Check();
                    break;
                case 3:
                    ContactDetails();
                    ViewDetail();
                    Console.WriteLine("Press Enter To continue");
                    Check();
                    break;
                case 4:
                    ContactDetails();
                    edit();
                    Console.WriteLine("Press enter to Continue");
                    Console.ReadLine();
                    Check();
                    break;
                case 5:
                    ContactDetails();
                    Delete();
                    Console.WriteLine("Press enter to continue");
                    Check();
                    break;
                case 6:
                    break;
            }
        }
    }
}
