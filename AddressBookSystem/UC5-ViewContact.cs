using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC5_ViewContact:UC4_DeleteContact
    {
        public void ContactDetails()
        {
            Console.WriteLine("\nAddress Book Contains following members : ");

            foreach (var item in contact.Keys)
            {
                Console.WriteLine("Name : {0}", item);
            }
        }

        public void ViewDetail()
        {
            Console.Write("\n  Enter the name of member to view details : "); var dict = Console.ReadLine().ToUpper();

            foreach (var item in contact[dict])
            {
                Console.WriteLine(" >> {0}", item);
            }
        }
    }
}
