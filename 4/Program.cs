// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Ваше число " + n);
int chetnoe = 1;
int max = n;
Console.WriteLine("Все четные числа от 1 до " + n );
while (chetnoe <= max)
{
    if (chetnoe % 2 == 0) 
    {
        Console.Write(chetnoe + ", ");
    }
    chetnoe ++;
}



