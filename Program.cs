﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите число: ");
int end = Convert.ToInt32(Console.ReadLine()); 
for (int i = 1; i <= end; i++) 
{
    Console.Write(Math.Pow(i, 3) + " ");
}