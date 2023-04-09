// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double ReadInt(string message)
{
    System.Console.Write($"{message} -> ");
    return Convert.ToDouble(Console.ReadLine());

}

double[] CreateArray(double dlina, double max, double min)
{
    double[] array = new double[10];
    Random rnd = new Random();
    for (int i = 0; i < dlina; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()*10, 2);

    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

double Different (double[] array)
{
    double sum;
    double min = 1000000;
    double max = 0;
    
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i]>max)
        {
            max = array[i];
        }

        if(array[i]<min)
        {
            min = array[i];
        }

    }

return max-min;


}


double lentgh = ReadInt("Введите длину массива");
double max = ReadInt("Введите максимальное число диапозона массива");
double min = ReadInt("Введите минимальное число диапозона массива");

double[] massive = CreateArray(lentgh, max, min);

 double result = Different(massive);

PrintArray(massive);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным значением в массиве = {result}");

