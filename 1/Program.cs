// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.Co    
Console.WriteLine("Введите число №1");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2");
int numb2 = int.Parse(Console.ReadLine());
Console.WriteLine("число №1 = " + numb1 + " число №2 = " + numb2);

if(numb1 > numb2) 
{
    Console.WriteLine("max = " + numb1);
}
else
{
    Console.WriteLine("max = " + numb2);

}

