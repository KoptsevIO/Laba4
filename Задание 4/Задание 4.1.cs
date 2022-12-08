Console.Write("Введите коэффициент а: ");
float a = Convert.ToSingle(Console.ReadLine());

Console.Write("Введите коэффициент b: ");
float b = Convert.ToSingle(Console.ReadLine());

Console.Write("Введите коэффициент c: ");
float c = Convert.ToSingle(Console.ReadLine());

Square(1, 2, 1);

void Square (float a, float b, float c)
{
    if (a == 0)
    {
        Console.WriteLine("Коэффициент a не должен равняться 0\n");
        return;
    }

    var discriminant = (b * b) - (4 * a * c);

    if (discriminant >= 0)
    {
        var x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
        var x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);

        if (x1 == x2)
        {
            Console.WriteLine($"Уравнение ({a})x^2 + ({b})x + ({c}) = 0" +
                          $" имеется лишь один корень:" +
                          $"\n\nX1 = {x1}\n");
        }

        else
        {
            Console.WriteLine($"Уравнение ({a})x^2 + ({b})x + ({c}) = 0" +
                         $" имеет два корня:" +
                         $"\n\nX1 = {x1}\nX2 = {x2}\n");
        }

    }

    else
    {
        Console.WriteLine($"Уравнение ({a})x^2 + ({b})x + ({c}) = 0" +
                          $" не имеет корней:");
    }
}
