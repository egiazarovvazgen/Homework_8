// Программа, которая задаёт прямоугольный двумерный массив и находит в нём строку с наименьшей суммой элементов

Console.WriteLine("Введите значение m: ");
var m = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите значение n: ");
var n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
var array = CreateArray(m, n);
if (m != n)
{
    PrintArray(array);
    FindRow(array);
}
else
{
    Console.WriteLine("Вы задали непрямоугольный массив");
    Console.WriteLine();
}

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 200);
        }
    }
    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}

void FindRow(int[,] input)
{
    int minSumOfRowElements = 0;
    int sumOfRowElements = SumOfRowElements(input, 0);
    for (int i = 1; i < input.GetLength(0); i++)
    {
        int tempSumOfRowElements = SumOfRowElements(input, i);
        if (sumOfRowElements > tempSumOfRowElements)
        {
            sumOfRowElements = tempSumOfRowElements;
            minSumOfRowElements = i;
        }
    }
    Console.WriteLine($"\n{minSumOfRowElements + 1} - строкa с наименьшей суммой элементов: {sumOfRowElements}");
}

int SumOfRowElements(int[,] input, int i)
{
    int sumOfRowElements = input[i, 0];
    for (int j = 1; j < input.GetLength(1); j++)
    {
        sumOfRowElements += input[i, j];
    }
    return sumOfRowElements;
}