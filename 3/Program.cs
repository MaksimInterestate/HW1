﻿//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


int a = 15;
Console.WriteLine("Четное ли число " + a + "?");
if(a % 2 == 0)
{
    Console.WriteLine("Ответ: да ");
}
else
{
    Console.WriteLine("Ответ: нет ");
}