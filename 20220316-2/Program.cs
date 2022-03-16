using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace _20220316_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char op;   //只有一個字元(加減乘除)

            Console.Write("Number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operator(+, -, *, /):");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    Console.WriteLine("{0}", a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}", a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}", a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}", Convert.ToDouble(a) / b);
                    break;
                default:
                    Console.WriteLine("無法執行你要求的運算");
                    break;
            }
            Console.ReadLine();
        }
    }
}*/



namespace _20220316_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double c=999D;
            char op;   //只有一個字元(加減乘除)

            Console.Write("Number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operator(+, -, *, /):");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    c = Convert.ToDouble(a + b);
                    break;
                case '-':
                    c = Convert.ToDouble(a - b);
                    break;
                case '*':
                    c = Convert.ToDouble(a * b);
                    break;
                case '/':
                    c = Convert.ToDouble(a) / b;
                    break;
                default:
                    Console.WriteLine("無法執行你要求的運算");
                    break;
            }
            if (c != 999D)
                Console.WriteLine("計算結果是；{0}", c);
            Console.ReadLine();
        }
    }
}
