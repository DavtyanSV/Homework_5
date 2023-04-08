// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

string HaveInt(int number, int[] array)
{
    string text = "нет";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            text = "да";
            break;
        }
    }
    return text;
}

int lentgh = ReadInt("Введите длину массива");
int max = ReadInt("Введите максимальное число диапозона массива");
int min = ReadInt("Введите минимальное число диапозона массива");
int numb = ReadInt("Введите число которое хотите проверить на наличие в массиве");

int[] massive = CreateArray(lentgh, max, min);
string answer = HaveInt(numb, massive);
PrintArray(massive);
System.Console.WriteLine();
System.Console.WriteLine(answer);
