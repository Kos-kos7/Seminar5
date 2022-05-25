// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

int[] nums = new int[5];
var numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 100);
    Console.Write(nums[i] + " ");
    
}

int max = 0;
for (int i = 0; i < nums.Length; i++)
{
   if (nums[i] > max)
   {
       max = nums[i];
   }
}
Console.WriteLine("Максимальный элемент массива: " + max);

int min = nums[0];
for (int i = 0; i < nums.Length; i++)
{
   if (nums[i] < min)
   {
       min = nums[i];
   }
}
Console.WriteLine("Минимальный элемент массива: " + min);

int dif = max - min;

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: " + dif);