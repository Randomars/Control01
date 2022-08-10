string[,] templates = new string[,]
{
    {"hello",   "2",        "world",    ":-)"   },
    {"1234",    "1567",     "-2",       "computer science"  },
    {"Russia",  "Denmark",  "Kazan",    ""},
};

int InputNum(string tip)
{
    Console.Write(tip);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintString(string[] workArray)
{
    for (int i = 0; i < workArray.GetLength(0); i++)
    {
        Console.Write(workArray[i] + " ");
    }
    Console.WriteLine();
}

string[] GetString1(string[,] workArray, int numString)
{
    string[] newString = new string[workArray.GetLength(1)];

    for (int i = 0; i < workArray.GetLength(1); i++)
    {
        newString[i] = workArray[numString - 1, i];
    }
    return newString;
}

string[] SelectShort(string[] strings, int maxChar)
{
    string[] strings2 = new string[strings.GetLength(0)];
    int countCurrent = 0;

    for (int i = 0; i < strings.GetLength(0); i++)
    {
        Console.WriteLine(strings[i].Length);
        if (strings[i].Length <= maxChar)
        {
            strings2[countCurrent] = strings[i];
            countCurrent++;
        }
    }
    return strings2;
}

// Начало программы

int template = 0;
int maxChar = 3;

Console.Clear();
while (template < 1 || template > 3)
{
    Console.WriteLine("Введите номер шаблона.");
    template = InputNum("Введите число (1-3): ");
}
Console.Clear();
Console.WriteLine($"Использую {template} шаблон.");
string[] myStrings = GetString1(templates, template);
PrintString(myStrings);
Console.WriteLine($"Оставляю короткие слова (< {maxChar}).");
string[] myStrings2 = SelectShort(myStrings, maxChar);
PrintString(myStrings2);


//Print2DArray(strings1[1, template]);