﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Ведите число N ");
int N = int.Parse(Console.ReadLine()!);
int k = 1;
while (k <= N)
{
    
    Console.Write($"{Math.Pow(k,3)}");
    
    //Ставим точки с пробелом после каждого числа , кроме последнего !

    if(k != N)
    {
        Console.Write(", ");
    }
    k++;
}
Console.WriteLine();