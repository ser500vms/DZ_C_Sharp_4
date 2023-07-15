// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение через Math.Pow:

// int GetPower(int num1, int num2)
// {
//     double power = 0;
//     power = Math.Pow(num1, num2);
//     return Convert.ToInt32(power);
// }

// int GetInput(string text)
// {
//     Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int number1 = GetInput("Введите 1-е число: ");
// int number2 = GetInput("Введите 2-е число: ");
// Console.Write($"{number1}, {number2} -> {GetPower(number1, number2)}");

// Решение через цикл:

int GetPower(int num1, int num2)
{
    int power = 1;
    int count = 0;
    while (count < num2)
    {
        power = power * num1;
        count++;
    }
    return power;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetInput("Введите 1-е число: ");
int number2 = GetInput("Введите 2-е число: ");
Console.Write($"{number1}, {number2} -> {GetPower(number1, number2)}");

