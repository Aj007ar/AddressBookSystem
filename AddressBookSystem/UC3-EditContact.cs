using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class UC3_EditContact:UC2_AddContact
    {
        public void edit()
        {
            Console.WriteLine("\nEnter Full name for edit contacts : ");
            var dict = Console.ReadLine().ToUpper();
            if (!dict.Contains(dict))
                Console.WriteLine("User Not Found"); edit();

            Console.WriteLine("1.Edit address");
            Console.WriteLine("2.Edit City");
            Console.WriteLine("3.Edit State");
            Console.WriteLine("4.Edit Zip");
            Console.WriteLine("5.Edit Phone Number");
            Console.WriteLine("6.Edit Email");
            Console.WriteLine("7.Invalid Input");
            var index = Convert.ToInt32(Console.ReadLine());

            switch (index)
            {
                case 1:
                    Console.WriteLine("Current address : {0}", contact[dict][index-1]);
                    Console.WriteLine("Enter New Address");
                    contact[dict][index - 1] = Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Current City : {0}", contact[dict][index - 1]);
                    Console.WriteLine("Enter New City");
                    contact[dict][index - 1] = Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Current State : {0}", contact[dict][index - 1]);
                    Console.WriteLine("Enter New State");
                    contact[dict][index - 1] = Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Current zip : {0}", contact[dict][index - 1]);
                    Console.WriteLine("Enter New zip");
                    contact[dict][index - 1] = Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Current Phone Number : {0}", contact[dict][index - 1]);
                    Console.WriteLine("Enter New Phone Number");
                    contact[dict][index - 1] = Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine("Current Email : {0}", contact[dict][index - 1]);
                    Console.WriteLine("Enter New Email");
                    contact[dict][index - 1] = Console.ReadLine();
                    break;
            }
        }
    }
}
