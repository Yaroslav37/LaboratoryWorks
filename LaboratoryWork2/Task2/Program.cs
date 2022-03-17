//Лабораторная работа №2, Выполнил Миненков Я. А., Вариант 16
/*
 * Дана точка на плоскости с координатами (х, у). Составить программу, 
  которая выдает одно из сообщений "Да", "Нет", "На границе" в зависимости от 
  того, лежит ли точка внутри заштрихованной области, вне заштрихованной 
  области или на ее границе
 */

void whereIsPoint(double x, double y)
{
    if ((x < 10 && x > 0 && y > 0 && y < 5))
    {
        Console.WriteLine("Да");
    }
    else if ((x == 10 && y >= 0 && y <= 5) || (y == 5 && x >= 0 && x <= 10))
    {
        Console.WriteLine("На границе");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

double x, y;

bool proceed = true;

while (proceed)
{
    Console.WriteLine("Введите координаты точек x и y: ");

    x = Convert.ToDouble(Console.ReadLine());
    y = Convert.ToDouble(Console.ReadLine());

    whereIsPoint(x, y);

    string? ans = Convert.ToString(Console.ReadLine());

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

