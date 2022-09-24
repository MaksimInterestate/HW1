// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void zadanie10 ()
{

    Console.WriteLine("Введите трехзначное число ");
    int number = Convert.ToInt32(Console.ReadLine()); //превращаем что ввел пользователь в 32битное число и записываем в number
    string numberToText = Convert.ToString(number);
    Console.WriteLine("Вторая цифра в вашем числе " + numberToText[1]);  

    // ИЛИ
    // Console.WriteLine("Введите трехзначное число ");
    // int numb1 = int.Parse(Console.ReadLine());
    // int numb2 = (numb1 / 10) % 10;
    // Console.WriteLine("Вторая цифра в вашем числе " + numb2); 

}
//zadanie10();
void zadanie13 ()
{
    
    Console.Write("Введи число: ");
    int number = int.Parse(Console.ReadLine()); //превращаем что ввел пользователь в 32битное число и записываем в number
    string numberToText = Convert.ToString(number); //переменную number конвертируем в стринг, чтобы посчитать кол-во знаков
    if (numberToText.Length > 2)
    {
        Console.WriteLine("Третья цифра " + numberToText[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }

}
//zadanie13();

void zadanie15()
{
    Console.WriteLine("Введите число, обозначающее день недели: ");
    int numb = int.Parse(Console.ReadLine());
    Console.Write(numb + "  число ");
    if(numb > 0  && numb <= 5) 
    {
        Console.Write(" - Будний день");
    }
        else 
    {
        Console.Write(" - Выходой день ");
    }
}
zadanie15 ();



