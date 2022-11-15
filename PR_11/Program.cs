using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                int i;
                string s = null;
                Console.Write("Введите текст:");
                s = Console.ReadLine();
                char[] c = s.ToCharArray();
                for (i = 0; i <= c.Length; i++) ;
                {
                    if (c[i] == c[c.Length - 1]) ;


                }

            
            }
        } 
    }
}
