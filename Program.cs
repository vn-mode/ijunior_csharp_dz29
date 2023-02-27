using System;

namespace vn_mode_csharp_dz29
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;

            int playerHealth = 10;
            int maxHealth = 100;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 0);
                DrawHealthbar(playerHealth, maxHealth);

                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Доступные команды:");
                Console.WriteLine("Ввести желаемый процент здоровья - 1");
                Console.WriteLine("Выйти из программы - 2" + "");

                Console.SetCursorPosition(0, 7);
                Console.Write("Введите команду: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите желаемый процент здоровья: ");
                        playerHealth = Convert.ToInt32(Console.ReadLine());
                        DrawHealthbar(playerHealth, maxHealth);
                        break;

                    case "2":
                        Console.WriteLine("Вы вышли из программы.");
                        Console.ReadKey();
                        isOpen = false;
                        break;
                }

                Console.Clear();
            }
        }

        static void DrawHealthbar(int playerHealth, int maxHealth, char symbolHealth = '#', char symbolEmptyHealth = '_')
        {
            string bar = "";

            for (int i = 0; i < playerHealth; i += 10)
            {
                bar += symbolHealth;
            }

            Console.Write($"[{bar}");
            bar = "";

            for (int i = playerHealth; i < maxHealth; i += 10)
            {
                bar += symbolEmptyHealth;
            }

            Console.Write($"{bar}] {playerHealth}%");
        }
    }
}

