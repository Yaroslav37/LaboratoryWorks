using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class triangle
    {
        public string triangleIsExists(double a, double b, double c)
        {
            string result;
            if (a + b <= c || b + c <= a || a + c <= b)
            {
                result = "Треугольник не существует!";
            }
            else
            {
                result = "Треугольник существует!";
            }
            return result;
        }

        static void Main(string[] args)
        {
            bool proceed = true;
            double a, b, c;
            string ans = "";

            while (proceed)
            {
                Console.WriteLine("Введите сторону a: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите сторону b: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите сторону c: ");
                c = Convert.ToDouble(Console.ReadLine());

                triangle method = new triangle();

                Console.Write(method.triangleIsExists(a, b, c));

                Console.Write("Желаете ли вы продолжить(\"Yes\" или \"No\"): ");

                ans = Convert.ToString(Console.ReadLine());

                switch (ans)
                {
                    case "Yes": break;
                    case "No":
                        Console.WriteLine("Программа завершена!");
                        proceed = false;
                        break;
                    default: proceed = false; break;
                }
            }
        }
    }
}
