﻿Console.WriteLine("Введите координату X первой точки");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X первой точки");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double res = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {res}");

