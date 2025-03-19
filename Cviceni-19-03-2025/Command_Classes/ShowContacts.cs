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
                int number = 0;
                rc.usrInputConsoleColor();
                foreach (Contact contact in contacts)
                {
                    number++;
                    Console.WriteLine($"{number}. {contact}");
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("(type anything to get back to menu)");
                Console.ReadKey();
                rc.resetConsoleColor();
                Console.Clear();
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
