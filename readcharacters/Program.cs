using System;

namespace readcharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte countcharacter = 0;
            byte countspace = 0;
            ConsoleKeyInfo i = Console.ReadKey();


            while (i.KeyChar != '.')
            {
                switch (i.KeyChar)
                {
                    case '\r':
                        Console.WriteLine();
                        break;
                    case '\b':
                        if (countcharacter != 0)
                        {
                            Console.Write(" \b");
                            countcharacter--;
                        }

                        break;
                    case ' ':
                        countspace++;
                        break;
                    default:
                        if (i.KeyChar != '.') countcharacter++;
                        break;
                }
                i = Console.ReadKey();
            }

            Console.WriteLine($"\nВы ввели {countcharacter} символов");
            Console.WriteLine($"Вы ввели {countspace} пробелов");
        }
    }
}