using System;

namespace Big_O_notation__searching___sorting_algo;
class Program
{
    static void Main(string[] args)
    {

        //int[] numbers = { 4, 9, 15, 22, 32 };
        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}
        //Console.WriteLine(sum);


        //int[] numbers = { 11, 14, 17, 45, 82, 90 };
        //int max = numbers[0];
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] > max)
        //        max = numbers[i];
        //}
        //Console.WriteLine(max);


        //int[] numbers = { 5, 10, 15, 20, 25 };
        //int sum = 0;
        //int number1 = numbers[0];
        //int number2 = numbers[numbers.Length - 1];

        //sum = sum + number1 + number2;
        //Console.WriteLine(sum);

        // int n = 233;
        // if (n <= 0)
        //     Console.WriteLine("Enter another value");
        //while (n % 2 == 0)
        //     n /= 2;
        // if (n != 1)
        //     Console.WriteLine("No");
        // else
        // Console.WriteLine("Yes");


        //int n = 3843;
        //int sum = default;
        //while (n % 10 > 0)
        //{
        //    n /= 10;
        //    sum ++;
        //}
        //Console.Write(sum);

        int[] numbers = { 1, 15, 19, 25, 28, 34, 49, 52, 87, 100 };
        int a = 28;
        bool number1 = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == a)
            {
                Console.WriteLine(i);
                number1 = true;
            }
        }
        if (!number1)
        { 
            Console.WriteLine("-1");
            
        }



    }
}