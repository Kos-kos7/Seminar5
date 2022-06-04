// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число, которое мы будем переводить в двоичное: ");
int decnum = int.Parse(Console.ReadLine());

void BinNum(int num) 
{
    string binnum = "";
    int decnum = num;
    while (num > 0)
    {
        string text = (num % 2).ToString();
        num = num / 2;
        binnum = binnum + text;
    }
    Console.WriteLine($"Число {decnum} в двоичном формате: {binnum}");
}
BinNum(decnum);