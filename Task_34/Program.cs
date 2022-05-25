//  Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.


int[] nums = new int[4];
var numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(99, 1000);
    Console.Write(nums[i] + " ");
}

int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0)
    {
        count = count + 1;
    }
}

Console.WriteLine("Количество четных чисел в массиве равно: " + count);
