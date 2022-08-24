/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
значения которых лежат в отрезке [10,99].

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2] -> 0

[10, 11, 12, 13, 14] -> 5*/
class Program
{
    static void FillArray(int[]array)
    {
        int length=array.Length;
        for (int i = 0; i < length; i++)
        {
            array[i]=new Random().Next(1,1000);
        }
    }
    static void WriteArray(int[] array)
    {
        Console.WriteLine("Вывод массива");
        for (int i=0;i<array.Length;i++)
        {
        Console.Write(array[i]+" ");
        }
        Console.WriteLine(" ");
    }
    static int CountNumbers(int[] array)
    {
        int count=0;
        for (int i = 0; i < array.Length; i++)
        {
         if(array[i]>10&&array[i]<99)
         {
            count+=1;
         }  
        }
        Console.WriteLine("Количество элементов в промежутке от 10 до 99 - "+count);
        return count;
    }

    static void Main(string[]args)
    {
        int[] array=new int[123];
        FillArray(array);
        WriteArray(array);
        CountNumbers(array);
    }
}
