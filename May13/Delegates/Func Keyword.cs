using System;

namespace Linq_Practice.Practice1
{
    class Function
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;  // first "2 int" are input and third "int" is output

            int result = add(10, 10);

            Console.WriteLine(result);
        }
    }
}