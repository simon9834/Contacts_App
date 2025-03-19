
public class DeleteContact : ICommand
{
    private List<Contact> contacts;

    public DeleteContact(List<Contact> contacts)
    {
        this.contacts = contacts;
    }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}
