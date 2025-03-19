namespace Cviceni_19_03_2025.Command_Classes
{
    public class DeleteContact : ICommand
    {
        private List<Contact> contacts;

        public DeleteContact(List<Contact> contacts)
        {
            this.contacts = contacts;
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Write ur contacts name: ");
            string name = Console.ReadLine();
            foreach (Contact contact in contacts)
            {
                if (string.Equals(name, contact.name, StringComparison.OrdinalIgnoreCase))
                {
                    contacts.Remove(contact);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("contact removed!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Contact not found..");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
