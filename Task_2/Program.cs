﻿Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) {
    Console.WriteLine($"MAX = {a} MIN = {b}");
} else {
    Console.WriteLine($"MAX = {b} MIN = {a}");
}
