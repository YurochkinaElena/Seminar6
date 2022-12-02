// Задача 39. Напишите программу, которая перевернет одномерный массив 
// (последний элемент будет на 1м месте, а первый на последнем и т.д.)

int[] array = {1, 2, 3, 4, 5};

Print(ReverseArray(array));

int[] ReverseArray(int[] array) 

{
    int length = array.Length;
    int[] result = new int[length];
    for(int i = length-1; i >= 0; i--)
    {
        result[length-1-i] = array[i];
    } 
    
    return result;
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