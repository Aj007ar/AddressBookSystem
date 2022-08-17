namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************WELCOME TO ADDRESS BOOK SYSTEM*************");
            Console.WriteLine("1. Create Contact in address book:");
            Console.WriteLine("Choose option for execute a program");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UC1_CreateContact createContact = new UC1_CreateContact();
                    createContact.Add_Contact();
                    break;
            }
        }
    }
}