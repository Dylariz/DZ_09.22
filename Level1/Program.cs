using System;
using System.Collections.Generic;
using System.Linq;

namespace Level1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            N1(); // <--------- Менять номер здесь и запускать
            WaterMark();
        }

        private static void N1()
        {
            int s = 0;
            for (int i = 2; i <= 35; i += 3)
            {
                s += i;
            }
            Console.WriteLine(s);
        }
        
        private static void N2()
        {
            double s = 0;
            for (double i = 1; i <= 10; i++)
            {
                s += 1 / i;
            }
            Console.WriteLine(s);
        }
        
        private static void N3()
        {
            double s = 0;
            for (double i = 2; i <= 112; i += 2)
            {
                s += i / (i + 1);
            }
            Console.WriteLine(s);
        }
        
        private static void N4()
        {
            double x = 1;
            double s = 0;
            for (double i = 1; i <= 9; i++)
            {
                s += Math.Cos(i * x) / Math.Pow(x, i - 1);
            }
            Console.WriteLine(s);
        }
        
        private static void N5()
        {
            double p = 2;
            double h = 3;
            double s = 0;
            for (double i = 0; i <= 9; i++)
            {
                s = Math.Pow(p + i * h, 2);
            }
            Console.WriteLine(s);
        }
        
        private static void N6()
        {
            for (double i = -4; i <= 4; i += 0.5)
            {
                Console.WriteLine($"x: {i}  y: {0.5 * Math.Pow(i, 2) - 7 * i}");
            }
        }
        
        private static void N7()
        {
            int s = 1;
            for (int i = 2; i <= 6; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
        }
        
        private static void N8()
        {
            int s = 0;
            for (int i = 1; i <= 6; i++)
            {
                int k = 1;
                for (int j = 1; j <= i; j++)
                {
                    k *= j;
                }

                s += k;
            }
            Console.WriteLine(s);
        }
        
        private static void N9()
        {
            double s = 0;
            for (int i = 1; i <= 6; i++)
            {
                int k = 1;
                for (int j = 1; j <= i; j++)
                {
                    k *= j;
                }

                s += Math.Pow(-1, i) * Math.Pow(5, i) / k;
            }
            Console.WriteLine(s);
        }
        
        private static void N10()
        {
            int res = 1;
            for (int i = 0; i < 7; i++)
            {
                res *= 3;
            }
            Console.WriteLine(res);
        }
        
        private static void N11()
        {
            for (int i = 1; i <= 6; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("5 ");
            }
        }
        
        private static void N12()
        {
            double x = 3;
            double s = 0;
            for (double i = 0; i <= 10; i++)
            {
                s += 1 / Math.Pow(x, i);
            }
            Console.WriteLine(s);
        }
        
        private static void N13()
        {
            for (double i = -15; i <= 15; i += 1)
            {
                if (i <= -10)
                {
                    Console.WriteLine($"x: {i/10}  y: {1}");
                }
                else if(i > 10)
                {
                    Console.WriteLine($"x: {i/10}  y: {-1}");
                }
                else
                {
                    Console.WriteLine($"x: {i/10}  y: {-i/10}");
                }
            }
        }
        
        private static void N14()
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(1);
            Console.WriteLine(1);
            Console.WriteLine(1);
            for (int i = 1; i < 6; i++)
            {
                arr.Add(arr[i - 1] + arr[i]);
                Console.WriteLine(arr[i + 1]);
            }
        }
        
        private static void N15()
        {
            List<double> chisl = new List<double>();
            chisl.Add(1);
            chisl.Add(2);
            
            List<double> znam = new List<double>();
            znam.Add(1);
            znam.Add(1);
            
            Console.WriteLine($"{chisl[0]} / {znam[0]}");
            Console.WriteLine($"{chisl[1]} / {znam[1]}");
            
            for (int i = 1; i < 4; i++)
            {
                chisl.Add(chisl[i - 1] + chisl[i]);
                znam.Add(znam[i - 1] + znam[i]);
                Console.WriteLine($"{chisl[i + 1]} / {znam[i + 1]}");
            }
            Console.WriteLine(chisl.Last() / znam.Last());
        }


        private static void WaterMark() // Не трогать
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Beep(700, 300);
            Console.WriteLine("\nCreated by Dylariz");
            Console.ResetColor();
        }
    }
}