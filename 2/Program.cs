//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число №1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №3");
int c = int.Parse(Console.ReadLine());


int max = a;
if(b > max) max = b;
if(c > max) max = c;
Console.Write("max = " + max);