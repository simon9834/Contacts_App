
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
        Console.Write("Write ur contact's number: ");
        string number = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Write ur contact's email: ");
        string email = Console.ReadLine();
        Console.Clear();
        foreach (var contact in contacts)
        {
            if (contact.name.Equals(name, StringComparison.OrdinalIgnoreCase) ||
                contact.phoneNum.Equals(number, StringComparison.OrdinalIgnoreCase) ||
                contact.email.Equals(email, StringComparison.OrdinalIgnoreCase))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("Duplicate contact found! This contact already exists.");
                Console.WriteLine();
            }
        }

        contacts.Add(new Contact(name, number, email));

        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("Contact added!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
