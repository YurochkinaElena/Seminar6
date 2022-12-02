// задача 44. Не используя рекурсию, выведите первые N числе Фибонначчи. 
// Первые два числа Фибоначчи 0 и 1.
//5 => 0 1 1 2 3

PrintFibanachiNum(10);

 void PrintFibanachiNum(int count)
 {
    int currentNum = 0;
    int currentcount = 2;
    int firstNum = 0;
    int secondNum = 1;
    Console.Write("0, 1,  ");
    while(currentcount != count)
    {
        currentNum = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = currentNum;
        Console.Write($"{currentNum}, ");
        currentcount++;
    }
 }