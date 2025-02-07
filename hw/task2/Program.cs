﻿// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

using System;


Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = AckermannFunction(m, n);
Console.Write($"Значение функции Аккермана для ({m}, {n}) равно: {result}");

int AckermannFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return AckermannFunction(m - 1, 1);
        else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }