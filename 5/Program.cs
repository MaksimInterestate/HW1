Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int m =1;
int f = 1;

while(m <= N)
{   
    f = f * m;
    m ++;
}
Console.WriteLine("Факториал числа " + N +" = " + f);