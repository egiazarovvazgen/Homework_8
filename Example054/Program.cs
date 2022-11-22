// Программа, которая задаёт двумерный массив и упорядочивает по убыванию элементы каждой его строки

Console.WriteLine("Введите значение m: ");
var m = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите значение n: ");
var n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
var array = CreateArray(m, n);
PrintArray(array);
Ordering(array);
PrintArray(array);

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
    Console.WriteLine();
}

void Ordering(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            for (var k = 0; k < input.GetLength(1) - 1; k++)
            {
                if (input[i, k] < input[i, k + 1])
                {
                    var temp = input[i, k + 1];
                    input[i, k + 1] = input[i, k];
                    input[i, k] = temp;
                }
            }
        }
    }
}