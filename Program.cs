using System;

namespace vn_mode_csharp_dz29
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string healthbar =  "[#_________]";
            int percent = 10;
            while (isOpen)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Ваш Healthbar: " + healthbar + " " + percent + "%");
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Доступные команды:");
                Console.WriteLine("Ввести желаемый процент здоровья - 1");
                Console.WriteLine("Выйти из программы - 2" +
                    "");
                Console.SetCursorPosition(0, 7);
                Console.Write("Введите команду: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Введите желаемый процент здоровья: ");
                        percent = Convert.ToInt32(Console.ReadLine());
                        EditeHealthbar(ref percent, ref healthbar);
                    break;
                    case "2":
                        Console.WriteLine("Вы вышли из программы.");
                        Console.ReadKey();
                        isOpen = false;
                    break;
                }
                Console.Clear();
            }

            static void EditeHealthbar(ref int percent, ref string healthbar)
            {
                if (percent > 0 && percent <= 10)
                {
                    healthbar = "[#_________]";
                }
                else if (percent > 10 && percent <= 20)
                {
                    healthbar = "[##________]";
                }
                else if (percent > 20 && percent <= 30)
                {
                    healthbar = "[###_______]";
                }
                else if (percent > 30 && percent <= 40)
                {
                    healthbar = "[####______]";
                }
                else if (percent > 40 && percent <= 50)
                {
                    healthbar = "[#####_____]";
                }
                else if (percent > 50 && percent <= 60)
                {
                    healthbar = "[######____]";
                }
                else if (percent > 60 && percent <= 70)
                {
                    healthbar = "[#######___]";
                }
                else if (percent > 70 && percent <= 80)
                {
                    healthbar = "[########__]";
                }
                else if (percent > 80 && percent <= 90)
                {
                    healthbar = "[#########_]";
                }
                else if (percent > 90 && percent <= 100)
                {
                    healthbar = "[##########]";
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
        }
    }
}

