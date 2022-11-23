using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_15
{
    class Program
    {
         public struct Payment
        {
            public char[] payeraccount;
            public char[] recipienttaccount;
            public char[] amount;

            public Payment(uint amount)
            {
                this.payeraccount = new char[20];
                this.recipienttaccount = new char[20];
                this.amount = new char[6];
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Практическая работа №15. \nЗдравствуйте!");
            Console.Write("укажите количество плательщиков:");
            uint countPayment = UInt32.Parse(Console.ReadLine());

            Payment[] payments = new Payment[countPayment];
            int i;
            for(i=0;i<countPayment;i++)
            {
                payments[i] = new Payment(0);
                Console.Write("\nРасчетный счет плательщика: ");
                payments[i].payeraccount = Console.ReadLine().ToCharArray();
                Console.Write("Расчетный счет получателя:");
                payments[i].recipienttaccount = Console.ReadLine().ToCharArray();
                Console.Write("Перечисляемая сумма в рублях:");
                payments[i].amount = Console.ReadLine().ToCharArray();
            }

            char[] new_payeraccount = new char[20];
            Console.Write("\nПоиск по расчетному счету плательщика ");
            new_payeraccount = Console.ReadLine().ToCharArray();

            bool flag = false;
            for(i=0;i<countPayment;i++)
            {
                if(String.Compare(new string(payments[i].payeraccount
                    ),new string(new_payeraccount))==0)
                {
                    Console.Write($"Расчетный счет плательщика: {new string(payments[i].payeraccount)} расчетный счет получателя:{new string(payments[i].recipienttaccount)}," +
                        $"Перечисляемая сумма:{new string(payments[i].amount)}");
                    flag = true;
                }
                
            }
            if (flag== false)
            {
                Console.Write("\n расчетный счет плательщика по запросу не найден!");
            }
            Console.ReadKey();
        }
    }
}
