//Лабораторная работа №2, Выполнил Миненков Я. А., Вариант 16
/*
 * Проверить, существует ли треугольник с длинами сторон a, b, c 
 */

void triangleIsExists(double a, double b, double c)
{
    if (a + b < c || b + c < a || a + c < b)
    {
        Console.WriteLine("Треугольник не существует!");
    }
    else
    {
        Console.WriteLine("Треугольник существует!");
    }
}

bool proceed = true;
double a, b, c;
string? ans = "";

while (proceed)
{
    Console.WriteLine("Введите сторону a: ");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите сторону b: ");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите сторону c: ");
    c = Convert.ToDouble(Console.ReadLine());

    triangleIsExists(a, b, c);

    Console.Write("Желаете ли вы продолжить(\"Yes\" или \"No\"): ");

    ans = Convert.ToString(Console.ReadLine());

    switch (ans)
    {
        case "Yes": break;
        case "No": Console.WriteLine("Программа завершена!");
                    proceed = false;
                    break;
        default: proceed = false; break;
    }
}