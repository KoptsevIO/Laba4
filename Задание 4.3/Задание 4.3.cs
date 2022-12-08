Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Binom(int m, int n)
{
    if (m > n & n >= 0)
    {
        return 0;
    }

    else if ((m == 0 & n > 0) | (m == n & m >= 0))
    {
        return 1;
    }
    else
    {
        return Binom(m - 1, n - 1) + Binom(m, n - 1);
    }
}

Console.WriteLine(Binom(m, n));
