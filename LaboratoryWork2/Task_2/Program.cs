using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Point
    {
        public string whereIsPoint(double x, double y)
        {
            string result;
            if ((x < 10 && x > 0 && y > 0 && y < 5))
            {
                result = "Да";
            }
            else if ((x == 10 && y >= 0 && y <= 5) || (y == 5 && x >= 0 && x <= 10))
            {
                result = "На границе";
            }
            else
            {
                result = "Нет";
            }
            return result;
        }

        static void Main(string[] args)
        {
            double x, y;

            bool proceed = true;

            while (proceed)
            {
                Console.WriteLine("Введите координаты точек x и y: ");

                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());

                Point method = new Point();
                Console.WriteLine(method.whereIsPoint(x, y));

                Console.Write("Желаете ли вы продолжить(\"Yes\" или \"No\"): ");

                string ans = Convert.ToString(Console.ReadLine());

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
