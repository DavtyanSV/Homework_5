// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] ReplaceArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

int lentgh = ReadInt("Введите длину массива");
int max = ReadInt($"Введите максимальное число диапозона массива");
int min = ReadInt($"Введите минимальное число диапозона массива");

int[] massive = CreateArray(lentgh, max, min);
PrintArray(massive);
System.Console.WriteLine();
ReplaceArray(massive);
PrintArray(massive);