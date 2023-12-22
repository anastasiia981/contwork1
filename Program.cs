// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы





using System;


class Program

{
    static void Main(string[] args)

    {
        int M = 1; 
        int N = 10; 

        PrintNumbers(M, N); 
    }


    static void PrintNumbers(int start, int end)

    {
        if (start > end)
        {
            return;
        }

        Console.WriteLine(start);

        PrintNumbers(start + 1, end);

    }

}















        


