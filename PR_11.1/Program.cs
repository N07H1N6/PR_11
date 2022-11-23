//*********************************************************************************
//*Практическая работа №11                                                        *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                           *
//* Задание: получение навыков работы с символьными данными и операциями над ними.*
//*********************************************************************************
using System;
using System.Linq;
using System.Linq.Expressions;

namespace PR_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствтвуйте");
            Console.WriteLine("Практическая работа № 11");
            try
            {               
                
                Console.Write("Введите текст:");
                string str = Console.ReadLine(); // Вводим строку
                string reverseStr = ""; // здесь будет наша перевернутая строка
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverseStr += str[i]; // переворачиваем строку
                }
                if (str == reverseStr)
                    Console.WriteLine("Введенная строка является палиндромом.");
                else
                    Console.WriteLine("Введенная строка не является палиндромом.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка:" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
