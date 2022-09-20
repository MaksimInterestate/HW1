//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int a = 22;
int b = 3;
int c = 9;
if(a > b)
{
    if(a > c)
    {
        Console.WriteLine("Максимальное число " + a);
    }
    else if(c > b)
    {
        Console.WriteLine("Максимальное число " + c);
    }
    else
    {
        Console.WriteLine("Максимальное число " + b);
    }
}
