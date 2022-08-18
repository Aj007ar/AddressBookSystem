using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Select:UC1_CreateContact
    {
        public void Check()
        {
            Console.WriteLine("1. Add contacts in address book:");
            Console.WriteLine("2.Exit");
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
                    break;
            }
        }
    }
}
