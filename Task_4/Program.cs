// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] MultiplicationEnd2End(int[] array)
{
    int j = array.Length / 2;
    if (array.Length % 2 > 0)
    {
        j++;
    }

    // int end_array = array.Length-1;

    int[] new_array = new int[j];
    for (int i = 0; i < new_array.Length; i++)
    {
        new_array[i] = array[i] * array[array.Length - 1 - i];
    }
    return new_array;
}

int lentgh = ReadInt("Введите длину массива");
int max = ReadInt("Введите максимальное число диапозона массива");
int min = ReadInt("Введите минимальное число диапозона массива");

int[] massive = CreateArray(lentgh, max, min);

PrintArray(massive);
int[] new_massive = MultiplicationEnd2End(massive);
System.Console.WriteLine();
PrintArray(new_massive);
