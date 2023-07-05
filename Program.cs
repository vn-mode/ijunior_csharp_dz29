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
                DrawHealthBar(playerHealth, maxHealth, stepHealthInBar);

                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Доступные команды:");
                Console.WriteLine("Ввести желаемый процент здоровья - 1");
                Console.WriteLine("Выйти из программы - 2");

                Console.SetCursorPosition(0, 7);
                Console.Write("Введите команду: ");

                string command = Console.ReadLine();

                switch (command)
                {
                    case CommandInputPlayerHealth:
                        try
                        {
                            Console.Write("Введите желаемый процент здоровья: ");
                            playerHealth = Convert.ToInt32(Console.ReadLine());
                            DrawHealthBar(playerHealth, maxHealth, stepHealthInBar);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Введенные данные не являются числом. Пожалуйста, введите число.");
                        }
                        break;

                    case CommandExit:
                        Console.WriteLine("Вы вышли из программы.");
                        Console.ReadKey();
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine($"Команда \"{command}\" не найдена. Пожалуйста, введите корректную команду.");
                        break;
                }

                Console.Clear();
            }
        }

        static void DrawHealthBar(int playerHealth, int maxHealth, int stepHealthInBar, char symbolHealth = '#', char symbolEmptyHealth = '_')
        {
            if (playerHealth <= maxHealth && playerHealth > 0)
            {
                string filledPart = new string(symbolHealth, playerHealth / stepHealthInBar);
                string emptyPart = new string(symbolEmptyHealth, (maxHealth - playerHealth) / stepHealthInBar);

                Console.Write($"[{filledPart}{emptyPart}] {playerHealth}%");
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
        }
    }
}
