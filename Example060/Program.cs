// Программа, которая формирует трёхмерный массив из неповторяющихся двузначных чисел и
// построчно выводит его, добавляя индексы каждого элемента

Console.WriteLine("Введите значение x: ");
var x = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите значение y: ");
var y = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine("Введите значение z: ");
var z = int.Parse(Console.ReadLine()!);
Console.WriteLine();
var array = CreateArray(x, y, z);
PrintArray(array);

int[,,] CreateArray(int rows, int columns, int aisles)
{
    var numbers = Enumerable.Range(10, 91).ToList();
    var random = new Random();
    int[,,] array = new int[rows, columns, aisles];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            for (var k = 0; k < aisles; k++)
            {
                var temp = random.Next(numbers.Count);
                array[i, j, k] = numbers[temp];
                numbers.RemoveAt(temp);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            for (var k = 0; k < input.GetLength(2); k++)
            {
                Console.Write(input[i, j, k]);
                if (i != input.GetLength(0)) Console.Write(" " + (i, j, k) + " ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}