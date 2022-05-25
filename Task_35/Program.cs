// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]
Random rnd = new Random();
int[] initArray;

    int[] array = new int[10];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,250);
        Console.Write(array[i] + " ");
    }




int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 10 && array[i] < 100)
    {
        count = count + 1;
    }
}
Console.WriteLine(count);