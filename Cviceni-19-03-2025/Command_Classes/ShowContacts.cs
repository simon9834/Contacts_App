
public class ShowContacts : ICommand
{
    private List<Contact> contacts = new List<Contact>();

    public ShowContacts(List<Contact> contacts)
    {
        this.contacts = contacts;
    }
    public void Execute()
    {
        if (contacts.Count != 0)
        {
            Console.WriteLine();
        }
    }
}
