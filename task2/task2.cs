//Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Если набор данных - таблица

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// на выходе ожидаем получить

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


// часть2
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
            matrix[i, j] = new Random().Next(0, 10);
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
Console.WriteLine("Вот исходный массив: ");
PrintArray(matr);
Console.WriteLine();

void FunctionTwo(int[,] matrix)
{
    int count;
    for (int k = 0; k < 10; k++)
    {
        count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                if (matrix[i, j] == k)
                    count++;
            }
        }
        if (count > 0)
            Console.WriteLine(k + " встречается " + count + "раз(а)");
    }
}
FunctionTwo(matr);
