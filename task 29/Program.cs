// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int []RandomArray(int number)
{
    int []array = new int[number];
     for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(1,10);
    }
    return array;
}

void PrintArray(int[] array)
{
int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(RandomArray(8));