// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l
// “World” => W r l d
// “Hello world!” => H l l w r l d



using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintConsonants(input);
        }

        static void PrintConsonants(string str, int index = 0)
        {
            if (index == str.Length)
                return;

            char c = str[index];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                PrintConsonants(str, index + 1);
            }
            else
            {
                Console.Write(c);
                PrintConsonants(str, index + 1);
            }
        }
    }
}