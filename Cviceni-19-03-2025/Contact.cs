
public class Contact
{
    private string name;
    private string phoneNum;
    private string email;

    public Contact(string name, string phoneNum, string email)
    {
        this.name = name;
        this.phoneNum = phoneNum;
        this.email = email;
    }
    public override string ToString()
    {
        return $"NAME: {name}, PHONE NUMBER: {phoneNum}, EMAIL: {email}";
    }
}
