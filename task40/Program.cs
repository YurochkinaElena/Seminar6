﻿// Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины?
//Теорема о неравенстве треугольника: каждая сторона треугольника меньще суммы двух других сторон.

bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((b + c) > a) && ((a + c) > b));
}

IsTriangle(2, 4, 3);
System.Console.WriteLine(IsTriangle(2, 4, 3));