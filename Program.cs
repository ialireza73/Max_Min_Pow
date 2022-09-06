using System;

namespace Max_Min_Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("weclome");
            System.Console.WriteLine("Please Enter 2 integere number..");
            double pow_result = Pow(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            System.Console.WriteLine("Pow result: " + pow_result);

            System.Console.WriteLine("please enter 5 number:");

            double[] my_doubles = {
              Convert.ToDouble(Console.ReadLine())
            , Convert.ToDouble(Console.ReadLine())
            , Convert.ToDouble(Console.ReadLine())
            , Convert.ToDouble(Console.ReadLine())
            , Convert.ToDouble(Console.ReadLine())
             };
            double max = Find_max(my_doubles);
            double min = Find_min(my_doubles);
            System.Console.WriteLine("this is the max: " + max);
            System.Console.WriteLine("this is the min: " + min);
        }
        static double Pow(int p1, int p2)
        {
            double result = Math.Pow(p1, p2);
            return result;
        }

        static double Find_max(double[] parametere_array)
        {
            Array.Sort(parametere_array);
            double my_double = parametere_array[parametere_array.Length - 1];
            return my_double;
        }
        static double Find_min(double[] parametere_array)
        {
            Array.Sort(parametere_array);
            double my_double = parametere_array[0];
            return my_double;
        }
    }
}
