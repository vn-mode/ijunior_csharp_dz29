using System;

namespace vn_mode_csharp_dz29
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CommandInputPlayerHealth = "1";
            const string CommandExit = "2";

            bool isOpen = true;

            int playerHealth = 10;
            int maxHealth = 100;
            int stepHealthInBar = 10;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 0);
                DrawHealthbar(playerHealth, maxHealth, stepHealthInBar);

                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Доступные команды:");
                Console.WriteLine("Ввести желаемый процент здоровья - 1");
                Console.WriteLine("Выйти из программы - 2" + "");

                Console.SetCursorPosition(0, 7);
                Console.Write("Введите команду: ");

                switch (Console.ReadLine())
                {
                    case CommandInputPlayerHealth:
                        Console.Write("Введите желаемый процент здоровья: ");
                        playerHealth = Convert.ToInt32(Console.ReadLine());
                        DrawHealthbar(playerHealth, maxHealth, stepHealthInBar);
                        break;

                    case CommandExit:
                        Console.WriteLine("Вы вышли из программы.");
                        Console.ReadKey();
                        isOpen = false;
                        break;
                }

                Console.Clear();
            }
        }

        static void DrawHealthbar(int playerHealth, int maxHealth, int stepHealthInBar, char symbolHealth = '#', char symbolEmptyHealth = '_')
        {
            string bar = "";

            for (int i = 0; i < playerHealth; i += stepHealthInBar)
            {
                bar += symbolHealth;
            }

            Console.Write($"[{bar}");
            bar = "";

            for (int i = playerHealth; i < maxHealth; i += stepHealthInBar)
            {
                bar += symbolEmptyHealth;
            }

            Console.Write($"{bar}] {playerHealth}%");
        }
    }
}

