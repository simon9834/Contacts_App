
public class AddContact : ICommand
{
    private List<Contact> contacts;

    public AddContact(List<Contact> contacts)
    {
        this.contacts = contacts;
    }
    public void Execute()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Name ur contact: ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Write ur contacts number: ");
        string number = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Write ur contacts email: ");
        string email = Console.ReadLine();
        Console.Clear();
        contacts.Add(new Contact(name, number, email));
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Contact added!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
