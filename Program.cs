// Написать программу, которая обменивает элементы первой строки и последней строки.

Console.Clear();

Console.Write("Введите размер по Х: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите размер по Y: ");
int Y = int.Parse(Console.ReadLine());
int[,] array = new int[X, Y];
Random rnd = new Random();
int change = 0;

for (int i = 0; i < X; i++)
{
    for (int j = 0; j < Y; j++)
    {
        array[i, j] = rnd.Next(10, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


for (int k = 0; k < Y; k++)
{
    change = array[0, k];
    array[0, k] = array[array.GetLength(0) - 1, k];
    array[array.GetLength(0) - 1, k] = change;
}


for (int i = 0; i < X; i++)
{
    for (int j = 0; j < Y; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();