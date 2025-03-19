namespace Cviceni_19_03_2025.Command_Classes
{
    public class ShowContacts : ICommand
    {
        ResetColor rc = new ResetColor();
        private List<Contact> contacts;

        public ShowContacts(List<Contact> contacts)
        {
            this.contacts = contacts;
        }
        public void Execute()
        {
            rc.resetConsoleColor();
            Console.Clear();
            if (contacts.Count != 0)
            {
                rc.usrInputConsoleColor();
                foreach (Contact contact in contacts)
                {
                    Console.WriteLine(contact);
                }
                Console.WriteLine();
                rc.resetConsoleColor();
            }
            else
            {
                Console.Clear();
                rc.warningConsoleColor();
                Console.WriteLine("You dont have any contacts yet..");
                Console.WriteLine();
                rc.resetConsoleColor();
            }
        }
    }
}
