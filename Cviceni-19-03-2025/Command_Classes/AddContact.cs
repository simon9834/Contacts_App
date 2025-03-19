
public class AddContact : ICommand
{
    private string name;
    private int phoneNum;
    private string email;

    public AddContact(string name, int phoneNum, string email)
    {
        this.name = name;
        this.phoneNum = phoneNum;
        this.email = email;
    }

    public void Execute()
    {
        
    }
}
