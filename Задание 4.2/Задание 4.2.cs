// Функция создание массива
int[] CreateArr(int n)
{
    var r = new Random();
    int[] arr1 = new int[n];

    for (int i = 0; i < n; i++)
    {
        arr1[i] = r.Next(-100, 100);
    }

    return arr1;
}

// Функция вывода исходного массива
void PrintArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr1[i]}\t");
    }
}

// Функция сортировки массива методом пузырька
int[] SortBuble(int[] arr1)

{
    int temp;
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = i + 1; j < arr1.Length; j++)
        {
            if (arr1[i] < arr1[j])
            {
                temp = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = temp;
            }
        }
    }

    return arr1;
}

int[] arr2;
int[] arr3;

Console.Write("Введите размерность массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

arr2 = CreateArr(n);
Console.WriteLine("Одномерный массив без сортировки:\n");
PrintArray(arr2);
Console.WriteLine();

arr3 = SortBuble(arr2);
Console.WriteLine("\nОдномерный массив с сортировкой по убыванию\n");
PrintArray(arr3);
Console.WriteLine();
