namespace Methods___4._5_
{
    internal class Program
    {
        //Methods
        static void DrawMoomin()
        {
            Console.WriteLine("        //");
            Console.WriteLine("       (oo\\");
            Console.WriteLine("       / ._)");
            Console.WriteLine("      J _ =\\=");
            Console.WriteLine("      |   /");
            Console.WriteLine("3._.' |_|_);");
            Console.WriteLine("");
        }
        static void DrawApple()
        {
            Console.WriteLine("          .:'");
            Console.WriteLine("      __ :'__");
            Console.WriteLine("    .'`__`-'__``.");
            Console.WriteLine("   :__________.-'");
            Console.WriteLine("   :_________:");
            Console.WriteLine("    :_________`-;");
            Console.WriteLine("     `.__.-.__.'");
            Console.WriteLine("");
        }
        static void DrawAngel()
        {
            Console.WriteLine("    -=-");
            Console.WriteLine(" (\\  _  /)");
            Console.WriteLine(" ( \\( )/ )");
            Console.WriteLine(" (       )");
            Console.WriteLine("  `>   <'");
            Console.WriteLine("  /     \\  ");
            Console.WriteLine("  `-._.-'");
            Console.WriteLine("");
        }
        static void Joke()
        {
            string answer;
            Console.WriteLine("Knock knock");
            answer = Console.ReadLine().ToLower();
            while (answer != "who's there" & answer != "whos there" & answer != "who is there" & answer != "who's there?" & answer != "whos there?" & answer != "who is there?")
            {
                Console.WriteLine("*Ahem* KNOCK KNOCK");
                answer = Console.ReadLine().ToLower();
            }
            Console.WriteLine("My life");
            answer = Console.ReadLine().ToLower();
            while (answer != "my life who" & answer != "my life who?")
            {
                Console.WriteLine("Do I really need to repeat myself?");
                Console.WriteLine("*Ahem* MY LIFE");
                answer = Console.ReadLine().ToLower();
            }
            Console.WriteLine("My life's a joke");
            Console.WriteLine("");
        }

        //Other stuff
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Press 1 if you'd like to see some text art, or press 2 to hear a joke");
                int.TryParse(Console.ReadLine(), out int num);
                while (num != 1 & num != 2)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Please press 1 for text art or 2 for a joke");
                    int.TryParse(Console.ReadLine(), out num);
                }
                if (num == 1)
                {
                    Console.WriteLine("Press 1 for a Moomintroll, 2 for an Apple, or 3 for an Angel");
                    int.TryParse(Console.ReadLine(), out int artNum);
                    while  (artNum != 1 & artNum != 2 & artNum != 3)
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Press 1 for a Moomintroll, 2 for an Apple, or 3 for an Angel");
                        int.TryParse(Console.ReadLine(), out artNum);
                    }
                    if (artNum == 1)
                        DrawMoomin();
                    else if (artNum == 2)
                        DrawApple();
                    else if (artNum == 3)
                        DrawAngel();
                }
                else if (num == 2)
                    Joke();
            }
        }
    }
}