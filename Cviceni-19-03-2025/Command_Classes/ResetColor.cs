namespace Cviceni_19_03_2025.Command_Classes
{
    public class ResetColor
    {
        public void resetConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
        }
        public void warningConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(100);
        }
        public void usrInputConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(100);
        }
        public void usrCommandsConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(100);
        }
        public void approvedConsoleColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(100);
        }
    }
}

