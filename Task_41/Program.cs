// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел М, которые вы будете вводить: ");
int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int[] n = int.Parse(Console.ReadLine());
}
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

int n = 0;
for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0);
        n = n + 1;
    }
    return array;

Console.WriteLine("Число положительных чисел в массиве: {n}");
