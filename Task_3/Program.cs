// Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 

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

void CountTwoDigit(int[] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>9 && array[i]<100)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}






int lentgh = ReadInt("Введите длину массива");
int max = ReadInt("Введите максимальное число диапозона массива");
int min = ReadInt("Введите минимальное число диапозона массива");

int[] massive = CreateArray(lentgh, max, min);

PrintArray(massive);
System.Console.WriteLine();
CountTwoDigit(massive);