// Задача 29: Напишите программу, которая выдаёт массив из элементов
// введенных пользователем и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write("Введите данные для массива: ");
        collection[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int size = GetInput("Задайте длину массива: ");
int[] array = new int[size];
FillArray(array);

Console.Write($"{String.Join(", ", array)} -> [{String.Join(", ", array)}]");

