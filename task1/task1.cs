
//Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


// Пример: Есть набор данных

// { 1, 9, 9, 0, 2, 8, 0, 9 }

// частотный массив может быть представлен так:

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 10);
}
Console.Write(" { ");

for (int i = 0; i < array.Length; i++)
{
    if (i == (array.Length - 1))
    {
        Console.Write(array[i]);
    }
    else
    {
        Console.Write(array[i] + ", ");
    }
}
Console.Write(" } ");
Console.WriteLine("");

void FunctionOne(int[] arr)
{
    int count;
    for (int j = 0; j < 10; j++)
    {
        count = 0;
        for (int k = 0; k < arr.Length; k++)
        {
            if (arr[k] == j)
            { count++; }
        }
        if (count > 0)
            Console.WriteLine(j + " встречается " + count + "раз(а)");
    }
}
FunctionOne(array);



