using System;

namespace vn_mode_csharp_dz29
{
    class Program
    {
        const string CommandInputPlayerHealth = "1";
        const string CommandExit = "2";
        const string CommandPrompt = "Доступные команды:";
        const string CommandInputPrompt = "Введите команду: ";
        const string ExitMessage = "Вы вышли из программы.";
        const string InvalidCommandMessage = "Команда \"{0}\" не найдена. Пожалуйста, введите корректную команду.";
        const string InvalidHealthValueMessage = "Введено некорректное значение здоровья. Значение должно быть в диапазоне от 0 до 100.";
        const string HealthBarPrefix = "\n[";

        static void Main(string[] args)
        {
            int playerHealth = 100;
            const int maxHealth = 100;
            const int barSize = 10;

            while (true)
            {
                Console.Clear();
                DrawHealthBar(playerHealth, maxHealth, barSize);

                Console.WriteLine("\n\n" + CommandPrompt);
                Console.WriteLine("1 - Ввести желаемый процент здоровья");
                Console.WriteLine("2 - Выйти из программы");

                Console.Write("\n" + CommandInputPrompt);
                string command = Console.ReadLine();

                switch (command)
                {
                    case CommandInputPlayerHealth:
                        bool inputSuccess = InputPlayerHealth(ref playerHealth);
                        if (inputSuccess)
                            DrawHealthBar(playerHealth, maxHealth, barSize);
                        break;

                    case CommandExit:
                        Console.WriteLine(ExitMessage);
                        Console.ReadKey();
                        return;

                    default:
                        Console.WriteLine(string.Format(InvalidCommandMessage, command));
                        Console.ReadKey();
                        break;
                }
            }
        }

        static bool InputPlayerHealth(ref int playerHealth)
        {
            Console.Write("Введите желаемый процент здоровья: ");
            if (int.TryParse(Console.ReadLine(), out int tempHealth) && tempHealth >= 0 && tempHealth <= 100)
            {
                playerHealth = tempHealth;
                return true;
            }

            Console.WriteLine(InvalidHealthValueMessage);
            Console.ReadKey();
            return false;
        }

        static void DrawHealthBar(int playerHealth, int maxHealth, int barSize, char symbolHealth = '#', char symbolEmptyHealth = '_')
        {
            int filledCells = playerHealth * barSize / 100;
            int emptyCells = barSize - filledCells;

            string filledPart = new string(symbolHealth, filledCells);
            string emptyPart = new string(symbolEmptyHealth, emptyCells);

            Console.Write($"{HealthBarPrefix}{filledPart}{emptyPart}] {playerHealth}%");
        }
    }
}
