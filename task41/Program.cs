using task41;

// Задача 41. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


var arr1 = FillArray(9);
Print(arr1);
Console.WriteLine();

var arr2 = arr1.CopyArray();
Print(arr2);


int[] Copy(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
