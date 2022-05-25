// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

int[] nums = new int[5];
var numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 100);
    Console.Write(nums[i] + " ");
}

int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
   if (i % 2 != 0)
   {
       sum = sum + nums[i];
   }
   
}

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);