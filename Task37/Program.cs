/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3

[6 7 3 6] -> 36 21*/
class Program
{
    static void FillArray(int[]array)
    {
        int length=array.Length;
        for (int i = 0; i < length; i++)
        {
            array[i]=new Random().Next(1,10);
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
    static int[] NewArray(int[] array)
    {
        int [] NewArray;
       if(array.Length%2==0)
       {
            NewArray=new int [array.Length/2];
            for (int i = 0; i < array.Length/2; i++)
            {
                NewArray[i]=array[i]*array[array.Length-1-i];
            }
       }
       else
       {
             NewArray=new int [array.Length/2+1];
            for (int i = 0; i < array.Length/2+1; i++)
            {
                NewArray[i]=array[i]*array[array.Length-1-i];
                NewArray[array.Length/2]=array[array.Length/2];
            }
            
       }
       
       return  NewArray; 
    }  

    static void Main(string[]args)
    {
        int[] array=new int[7];
        FillArray(array);
        WriteArray(array);
        int[] new_array=NewArray(array);
        WriteArray(new_array);
    }
}