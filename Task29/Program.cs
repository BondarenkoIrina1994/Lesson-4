//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] ArrayRandom(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++)
        arr[i] = rnd.Next(0,99);
    return arr;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)  
        Console.Write($"[{array[i]}, ");
        else 
            if (i < array.Length-1)
             Console.Write($"{array[i]}, ");
             else 
             Console.Write($"{array[i]}]");
    }
}
int []arr_=ArrayRandom(8);
printArray(arr_);