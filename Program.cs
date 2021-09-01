using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod3
{
    class Program
    {
        enum Semaphore
        {
            Red = 100, 
            Yellow = 200,
            Green = 300,
        }

        static void Main(string[] args)
        {
            //Вывод строк ASCII
            Console.WriteLine("`Сначала - вывод строк, закодированных ASCII и Unicode");
            Console.WriteLine("Вывод символа '#' при помощи ASCII-кода \\x23: \x23");
            Console.WriteLine("Вывод символа '#' при помощи Unicode-кода \\u0023: \u0023");

            //Первый вариант анкеты (без вопросов пользователю)
            Console.WriteLine("\nПотом \"анкета\":");
            string firstName = "\x53\x65\x72\x67\x65\x79";
            byte ageInYears = (byte)(DateTime.Now.Year - 0x7b1); //наверное, byte - не самый эффективный тип в данном случае))
            var hasPet = new bool();
            float footSize = 0b1010111 / 2f;  //интересно, а как записать не-целое BIN или HEX 
            Console.WriteLine($"Имя: {firstName.ToString()}\nВозраст: {ageInYears}\nЕсть ли дома живность: {hasPet}\nРазмер ноги: {footSize}");

            //Перечисления
            Console.WriteLine("\nТеперь - перечисление Semaphore");
            Semaphore redLight = Semaphore.Red;
            Semaphore greenLight = (Semaphore)300;
            Console.WriteLine($"{redLight}, {(int)greenLight}");

            //Финальная практика модуля 3.7
            Console.WriteLine("\nИ наконец - вопросы:");
            Console.Write("Введите Ваше имя и нажмите Enter: ");
            firstName = Console.ReadLine();
            Console.Write("Сколько Вам лет? ");
            bool ageLooksCorrect = byte.TryParse(Console.ReadLine(), out ageInYears);
            Console.Write("Введите дату вашего рождения: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine($"Вот, что получилось: Вас зовут {firstName}, Вам {ageInYears}, дата Вашего рождения {birthDate}");

            Console.ReadKey();

        }
    }
}
