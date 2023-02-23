Console.WriteLine($"Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника");
    
    void Newtriangle(double[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
          if (array[i, j] != 0)
          {
            array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
            array[i, j] = 0;
            count++;
          }
        }
      }
      array[array.GetLength(0) - 1, 0] = 1;
    }
    
    void Fillingtriangle(double[,] triangle)
    {
      for (int k = 0; k < triangle.GetLength(0); k++)
      {
        triangle[k, 0] = 1;
      }
      for (int i = 1; i < triangle.GetLength(0); i++)
      {
        for (int j = 1; j < i + 1; j++)
        {
          triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }
      }
    }
    
    void WriteArray(double[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          if (array[i, j] != 0)
          {
              Console.Write($"{array[i, j]} ");
          }
          else Console.Write("  ");
        }
        Console.WriteLine();
      }
    }
    
    int n = numbers("Введите желаемое количество строк в треугольнике: ");
    
    double[,] triangle = new double[n + 1, 2 * n + 1];
    
    Fillingtriangle(triangle);
    
    Console.WriteLine();
    WriteArray(triangle);
    
    Newtriangle(triangle);
    
    Console.WriteLine();
    WriteArray(triangle);

    int numbers(string input)
    {
      Console.Write(input);
      int output = int.Parse(Console.ReadLine()!);
      return output;
    }
