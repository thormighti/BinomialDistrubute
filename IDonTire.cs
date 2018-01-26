using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int counnter = 0;
            while (counnter <= 100)
            {
                Console.WriteLine("input the number of sambles");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("input the number of variables");
                double x = Convert.ToDouble(Console.ReadLine());
                //making way for calculating success
                Console.WriteLine("Calculate your probability of success.\n note: probability of success(p)= sample points/ sample spaces ");

                try
                {
                    Console.WriteLine("Is the value of the probability of success and failure given in the question? \n press 1 for YES and 2 for no");
                    int Skip = int.Parse(Console.ReadLine()) ;

                    if (Skip == 1)
                    {
                        Console.WriteLine("input the value of Success");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("input the value of Failure");
                        double q = Convert.ToDouble(Console.ReadLine());
                        int y = (int)(n - x);
                        int Lau = (int)Perm(n, x);
                        //getting the combination;
                        double C;
                        C = Lau / TheOther(x);
                        //  double c = Math.Pow(2, 3);

                        Console.WriteLine("this is the combination {0}", C);
                        double Binomial = C * Math.Pow(p, x) * Math.Pow(q, y);
                        Console.WriteLine("the binomial distrubution is {0}", Binomial);
                    }
                    else
                    {
                        Console.WriteLine("inputs sample points");
                        double SampPoints = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("input sample space");
                        double SampSpace = Convert.ToDouble(Console.ReadLine());
                        //calculating probability of failure
                        double p = SampPoints / SampSpace;
                        double q = 1 - p;
                        int y = (int)(n - x);
                        int Lau = (int)Perm(n, x);
                        //getting the combination;
                        double C;
                        C = Lau / TheOther(x);
                        //  double c = Math.Pow(2, 3);

                        Console.WriteLine("this is the combination {0}", C);
                        double Binomial = C * Math.Pow(p, x) * Math.Pow(q, y);
                        Console.WriteLine("the binomial distrubution is {0}", Binomial);
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("you tried doing like this : a/b , make it in decimals or real number");
                    Console.WriteLine(e.Message);
                }
                counnter++;
            }
            Console.ReadKey();

        }
        static double TheOther(double c)
        {
            if (c == 0)
            {
                return 1;
            }
            else
            {
                return c * TheOther(c - 1);
            }
        }
        static double FactorialDiv(double n, double x)
        {
            int result = 1;
            for (int i = (int)n; i > x; i--)
            {
                result *= i;
            }
            return result;

        }
        static double Perm(double o, double s)
        {
            return FactorialDiv(o, o - s);
        }

    }
}
