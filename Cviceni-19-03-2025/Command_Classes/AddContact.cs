namespace Cviceni_19_03_2025.Command_Classes
{

    public class AddContact : ICommand
    {
        ResetColor rc = new ResetColor();
        private List<Contact> contacts;

        public AddContact(List<Contact> contacts)
        {
            this.contacts = contacts;
        }
        public void Execute()
        {
            rc.resetConsoleColor();
            Console.Clear();
            rc.usrCommandsConsoleColor();
            Console.Write("Name ur contact:");
            rc.usrInputConsoleColor();
            string name = Console.ReadLine();

            Console.WriteLine();

            rc.usrCommandsConsoleColor();
            Console.Write("Write ur contact's number:");
            rc.usrInputConsoleColor();
            string number = Console.ReadLine();

            Console.WriteLine();

            rc.usrCommandsConsoleColor();
            Console.Write("Write ur contact's email:");
            rc.usrInputConsoleColor();
            string email = Console.ReadLine();
            rc.resetConsoleColor();

            Console.Clear();

            foreach (var contact in contacts)
            {
                if (contact.name.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                    contact.phoneNum.Equals(number, StringComparison.OrdinalIgnoreCase) ||
                    contact.email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    rc.warningConsoleColor();
                    Console.WriteLine();
                    Console.WriteLine("Duplicate contact found! This contact already exists.");
                    Console.WriteLine();
                }
            }

            contacts.Add(new Contact(name, number, email));

            rc.approvedConsoleColor();
            Console.WriteLine("Contact added!");
            Thread.Sleep(2000);
            rc.resetConsoleColor();
            Console.Clear();
        }
    }
}
