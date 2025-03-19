

using Cviceni_19_03_2025.Command_Classes;

public class Menu
{
    private List<MenuItem> _menuItems = new List<MenuItem>();
    ResetColor rc = new ResetColor();
    public void add(MenuItem item)
    {
        _menuItems.Add(item);
    }
    public void DisplayMenu()
    {
        rc.resetConsoleColor();
        Console.WriteLine("Menu\n");
        rc.usrInputConsoleColor();
        Console.WriteLine("0. end program");
        for (int i = 0; i < _menuItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_menuItems[i].text}");
        }

        rc.resetConsoleColor();
        Console.WriteLine();
        Console.Write("Pick action: ");
        rc.usrInputConsoleColor();
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
                    rc.resetConsoleColor();
                    Console.Clear();
                    rc.warningConsoleColor();
                    Console.WriteLine("Closing App...");
                    Thread.Sleep(1500);
                    rc.resetConsoleColor();
                    Environment.Exit(0);
                }
                if(choice <= _menuItems.Count && choice > 0)
                {
                    _menuItems[choice - 1].SelectCommand();
                }
                else
                {
                    rc.resetConsoleColor();
                    Console.Clear();
                    rc.warningConsoleColor();
                    Console.WriteLine("this number doesnt really work well try again, or later, or never");
                    Thread.Sleep(1500);
                    rc.resetConsoleColor();
                    Console.Clear();
                }
            }
            else
            {
                rc.resetConsoleColor();
                Console.Clear();
                rc.warningConsoleColor();
                Console.WriteLine("bro thats not even a number");
                Thread.Sleep(1500);
                rc.resetConsoleColor();
                Console.Clear();
            }
        }
    }
}
