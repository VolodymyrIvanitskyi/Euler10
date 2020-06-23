using System;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 2;
            int sum = 0;
            bool flag = true;
            while(flag)
            {
                if(isSimple(k))
                {
                    if (k < 200000)
                    {
                        sum += k;
                    }
                    else flag = false; 
                }
                ++k;
            }
            Console.WriteLine($"Sum = {sum}");
        }

        static bool isSimple(int number)
        {
            for(int i = 2; i < number/2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
