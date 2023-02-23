//Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// задача про буквы

string ArrangeArray(string text)
{
    string chars = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя,.!:-;";
    string arrangeText = String.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        for (int j = 0; j < text.Length; j++)
        {
            if (text[j] == chars[i])
            {
                arrangeText += text[j];
            }
        }
    }

    return arrangeText;
}

int[] SearchRepeats(string arrangeText)
{
    int[] repeatsArray = new int[arrangeText.Length];

    for (int i = 0; i < arrangeText.Length; i++)
    {
        int count = 0;

        for (int j = 0; j < arrangeText.Length; j++)
        {
            if (arrangeText[i] == arrangeText[j])
            {
                count++;
            }
        }

        repeatsArray[i] = count;
    }

    return repeatsArray;
}

void PrintRepeats(int[] repeatsArray, string arrangeText)
{
    double frequency = Math.Round(((double)repeatsArray[0] / repeatsArray.Length) * 100, 2);
    Console.WriteLine($"/*Символ пробел/space встречается {repeatsArray[0]} раз. Частота {frequency}%");

    for (int i = 1; i < arrangeText.Length; i++)
    {
        if (arrangeText[i] != arrangeText[i - 1])
        {
            frequency = Math.Round(((double)repeatsArray[i] / repeatsArray.Length) * 100, 2);
            Console.WriteLine($"Символ {arrangeText[i].ToString()} встречается {repeatsArray[i]} раз. Частота {frequency}%");
        }
    }
}

string text = " Частотный анализ – это один из методовкриптоанализа, "
            + " основывающийся на предположении о существовании " 
            + " нетривиального статистического распределения отдельных "
            + " символов и их последовательностей как в открытом тексте,"
            + " так и шифрованном тексте, которое с точностью до замены "
            + " символов будет сохраняться в процессе шифрования "
            + " и дешифрования.";
            
Console.WriteLine(text);
Console.WriteLine();

string arrangeText = ArrangeArray(text);
int[] repeatsArray = SearchRepeats(arrangeText);
PrintRepeats(repeatsArray, arrangeText);
