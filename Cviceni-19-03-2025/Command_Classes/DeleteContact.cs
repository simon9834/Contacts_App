namespace Cviceni_19_03_2025.Command_Classes
{
    public class DeleteContact : ICommand
    {
        private List<Contact> contacts;
        ResetColor rc = new ResetColor();
        public DeleteContact(List<Contact> contacts)
        {
            this.contacts = contacts;
        }

        public void Execute()
        {
            rc.resetConsoleColor();
            if (contacts.Count != 0)
            {
                Console.Clear();
                rc.usrCommandsConsoleColor();
                Console.Write("Write ur contacts name: ");
                rc.usrInputConsoleColor();
                string name = Console.ReadLine();
                bool contactFound = false;

                foreach (Contact contact in contacts)
                {
                    if (string.Equals(name, contact.name, StringComparison.OrdinalIgnoreCase))
                    {
                        contacts.Remove(contact);
                        rc.resetConsoleColor();
                        Console.Clear();
                        rc.approvedConsoleColor();
                        Console.WriteLine("contact removed!");
                        Thread.Sleep(2000);
                        rc.resetConsoleColor();
                        contactFound = true;
                        Console.Clear();
                        break;
                    }
                }
                if (!contactFound)
                {
                    rc.warningConsoleColor();
                    Console.WriteLine("Contact not found..");
                    Thread.Sleep(2000);
                    rc.resetConsoleColor();
                    Console.Clear();
                }
            }
            else
            {
                Console.Clear();
                rc.warningConsoleColor();
                Console.WriteLine("You didnt add any contacts yet..");
                Thread.Sleep(2000);
                rc.resetConsoleColor();
                Console.Clear();
            }
        }
    }
}
