// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int ReadInt(string message)
{
    System.Console.Write($"{message} -> ");
    return int.Parse(Console.ReadLine());

}

int[] CreateArray(int dlina, int max, int min)
{
    int[] array = new int[dlina];
    Random rnd = new Random();
    for (int i = 0; i < dlina; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int Count_even (int[] array)
{
    int count_number = 0;

    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count_number++;
        }
    }

    return count_number;

}

int lentgh = ReadInt("Введите длину массива");
int max = ReadInt("Введите максимальное число диапозона массива");
int min = ReadInt("Введите минимальное число диапозона массива");

int[] massive = CreateArray(lentgh, max, min);

int result = Count_even(massive);

PrintArray(massive);
System.Console.WriteLine();
System.Console.WriteLine($"Кол-во четных числе в массиве = {result}");
