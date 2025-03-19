
public class Contact
{
    public string name {  get; set; }
    public string phoneNum { get; set; }
    public string email { get; set; }

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
