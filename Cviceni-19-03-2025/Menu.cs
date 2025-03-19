

public class Menu
{
    private List<MenuItem> _menuItems = new List<MenuItem>();

    public Menu(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }
    public void add(MenuItem item)
    {
        _menuItems.Add(item);
    }
    public void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Menu/n");
        Console.ForegroundColor = ConsoleColor.Blue;
        for (int i = 0; i < _menuItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_menuItems[i].text}");
        }
        Console.WriteLine("0. end program");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Pick action: ");
    }
    public void UserInpt()
    {
        bool runnin = true;
        int choice;
        while (runnin)
        {
            DisplayMenu();
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 0)
                {
                    runnin = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Closing App");
                    
                }
                if(choice <= _menuItems.Count && choice >= 0)
                {
                    _menuItems[choice - 1].SelectCommand();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("this number doesnt really work well try again, or later, or never");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("bro thats not even a number");
            }
        }
    }
}
