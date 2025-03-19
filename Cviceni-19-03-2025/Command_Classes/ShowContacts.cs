
public class ShowContacts : ICommand
{
    private List<Contact> contacts;

    public ShowContacts(List<Contact> contacts)
    {
        this.contacts = contacts;
    }
    public void Execute()
    {
        Console.Clear();
        if (contacts.Count != 0)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You dont have any contacts yet");
        }
    }
}
