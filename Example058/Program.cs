// Программа, которая задаёт две матрицы и находит их произведение

Console.WriteLine("Введите количество строк первой матрицы: ");
var m = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите количество столбцов первой матрицы: ");
var n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите количество строк второй матрицы: ");
var p = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите количество столбцов второй матрицы: ");
var q = int.Parse(Console.ReadLine()!);
Console.WriteLine();
var firstMatrix = CreateArray(m, n);
PrintArray(firstMatrix);
var secondMatrix = CreateArray(p, q);
PrintArray(secondMatrix);
var resultMatrix = CreateArray(m, p);
MatrixProduct(firstMatrix, secondMatrix, resultMatrix);
PrintArray(resultMatrix);

int[,] CreateArray(int rows, int columns)
{
    var random = new Random();
    int[,] array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
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

void MatrixProduct(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = result;
        }
    }
}