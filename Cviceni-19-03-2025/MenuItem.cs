
public class MenuItem
{
    public string text {  get; private set; }
    private ICommand command;

    public MenuItem(string text, ICommand command)
    {
        this.text = text;
        this.command = command;
    }
    public void SelectCommand()
    {
        command.Execute();
    }
}
