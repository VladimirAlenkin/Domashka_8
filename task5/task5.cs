// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Задача. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент. ");
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

int[,] matr = new int[m, n];
FillArray(matr);
Console.WriteLine("Вот так выглядит исходный массив: ");
PrintArray(matr);
Console.WriteLine();

int min = matr[0, 0];
int line = 0;
int column = 0;

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (matr[i, j] < min)
        {
            min = matr[i, j];
            line = i;
            column = j;
        }
    }
}
Console.WriteLine("Минимальное значение: " + min);
Console.WriteLine();
Console.WriteLine("позиции минимума: ");
Console.WriteLine(line);
Console.WriteLine(column);

int[,] newmatr = new int[(m - 1), (n - 1)];

void FillArrayNew(int[,] matrix, int[,] newmatrix)
{
    int k = 0;
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        int l = 0;
        if (k == line) k++;
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {
            if (l == column) l++;
            newmatrix[i, j] = matrix[k, l];
            l++;
        }
        k++;
    }
}

FillArrayNew(matr, newmatr);

Console.WriteLine();
PrintArray(newmatr);

