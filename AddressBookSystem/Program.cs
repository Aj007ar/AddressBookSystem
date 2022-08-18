namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************WELCOME TO ADDRESS BOOK SYSTEM*************");

            Select select = new Select();
           select.contact.Add("AJAY", new List<string> { "Darati", "Yavatmal", "Maharshatra", "445207", "7542156478", "ajay@gmail.com" });
            select.Check();
        }
    }
}