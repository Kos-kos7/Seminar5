// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число в десятичной системе для перевода в двоичную: ");
int numDec = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы счисления: ");
int baseNum = int.Parse(Console.ReadLine());

// int d10 = 1;
// long result = 0;

// while (numDec != 0)
// {
//     result = result + numDec % baseNum * d10;
//     numDec /= baseNum; //numDec = numDec / 2
//     d10 = d10 * 10;
// }

// Console.WriteLine(result);


void DecToOther (int num, int baseN)
{
    if (num == 0)
    {
        return;
    }
    DecToOther (num / baseN, baseN);

    Console.Write(num%baseN);
}

DecToOther (numDec, baseNum);

