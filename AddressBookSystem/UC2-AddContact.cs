using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Select:UC4_DeleteContact
    {
        public void Check()
        {
            Console.WriteLine("1. Add contacts in address book:");
            Console.WriteLine("2.Edit Contact Details");
            Console.WriteLine("3.Delete Contacts");
            Console.WriteLine("4.Exit");
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
                    edit();
                    Console.WriteLine("Press Enter To continue");
                    Check();
                    break;
                case 3:
                    Delete();
                    Console.WriteLine("Press enter to Continue");
                    Console.ReadLine();
                    break;
                case 4:
                    break;
            }
        }
    }
}
