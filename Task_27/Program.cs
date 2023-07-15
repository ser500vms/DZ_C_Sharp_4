// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetSum(string num)
{
    int[] array = new int[num.Length];
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        array[i] = Convert.ToInt32(num[i].ToString());
        sum = sum + array[i];
    }
    return sum;
}

string GetInput(string text)
{
    text = Console.ReadLine();
    return text;
}

string number = GetInput("Введите число: ");
int sum = GetSum(number);
Console.Write($"{number} -> {sum}");