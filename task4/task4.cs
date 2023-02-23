//Найти произведение двух матриц

Console.WriteLine("Найти произведение двух матриц");
Console.WriteLine();
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine()!);
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matr1 = new int[m, n];
int[,] matr2 = new int[m, n];

FillArray(matr1);
FillArray(matr2);
Console.WriteLine("Вот так выглядят исходные массивы: ");
PrintArray(matr1);
Console.WriteLine();
PrintArray(matr2);
Console.WriteLine();
int[,] matr3 = new int[m, n];
for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr3[i, j] = matr1[i, j] * matr2[i, j];
        }
    }

Console.WriteLine("Вот так выглядит их произведение: ");
PrintArray(matr3);
Console.WriteLine();
