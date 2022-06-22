// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(5, 7);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите номер строки элемента: ");
int rowNumber = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int colNumber = int.Parse(Console.ReadLine());

int[] position = new int[2]{rowNumber, colNumber};

if(position[0] <= 5
&& position[1] <= 7 
&& position[0] >= 0 
&& position[1] >= 0)
{
double result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write($"такого элемента в массиве нет.");