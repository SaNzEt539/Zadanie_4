using System;

namespace consoleTask_4_1
{
    class Program
    {
        static int F(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
        static int C(int m, int n)
        {
            if (m == 0 || m == n)
            {
                return 1;
            }
            return ((F(n) / (F(n - m) * m)) + C(m - 1, n - 1));
        }
        static void f(char a, int space, int count)
        {
            if (a=='Z') 
            {
                for (int i = 0; i < space; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < count; i++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < space; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
            f(++a, space + 1, count - 2);
            a--;
            for (int i = 0; i < space; i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int N, M;
            try
            {
                Console.Write("Введите N: ");
                N = int.Parse(Console.ReadLine());
                Console.Write("Введите M: ");
                M = int.Parse(Console.ReadLine());
                if (M<0 && N<M)
                {
                    throw new Exception();
                }
                int s = C(M, N);
                Console.WriteLine("Результат: {0}", s);

                Console.WriteLine("Задание 2");
                f('A', 0, 80);                
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено что-то не то");
            }
            catch(Exception)
            {
                Console.WriteLine("M должно быть больше или равно нулю, N должно быть больше или равно M");
            }

        }
    }
}
