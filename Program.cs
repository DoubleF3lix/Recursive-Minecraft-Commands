using System;

namespace RecursiveMinecraftCommands
{
    public class MCCmdRecurse
    {
        public static void Main()
        {
            Console.WriteLine("Enter the command you want to increment the numbers on (Replace any spot you want to increment with |)");
            Console.Write("> ");
            string command = Console.ReadLine();
            Console.WriteLine("Enter the starting number");
            Console.Write("> ");
            string startNumUnparsed = Console.ReadLine();
            Console.WriteLine("Enter the ending number");
            Console.Write("> ");
            string endNumUnparsed = Console.ReadLine();

            double.TryParse(startNumUnparsed, out double startNumParsed);
            double.TryParse(endNumUnparsed, out double endNumParsed);


            for (double i = startNumParsed; i <= endNumParsed; i++)
            {
                string output = command.Replace("|", $"{i}");
                Console.WriteLine(output);
            }

            Console.WriteLine();
            Console.WriteLine("Success. Right click, select \"Mark\", highlight the commands, right click again, and select \"Copy\". Pressing CTRL + C will exit the menu.");
            Console.WriteLine("Press any key to exit the menu.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}