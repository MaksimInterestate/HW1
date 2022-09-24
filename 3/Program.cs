//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Четное ли число " + a + "?");
if( a == 0) return;
if(a % 2 == 0)
{
    Console.WriteLine("Ответ: да ");
}
else
{
    Console.WriteLine("Ответ: нет ");
}