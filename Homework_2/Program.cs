// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int Sum_odd(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum += array[i];
        }
    }

    return sum;

}

int lentgh = ReadInt("Введите длину массива");
int max = ReadInt("Введите максимальное число диапозона массива");
int min = ReadInt("Введите минимальное число диапозона массива");

int[] massive = CreateArray(lentgh, max, min);

int result = Sum_odd(massive);

PrintArray(massive);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных чисел в массиве = {result}");
