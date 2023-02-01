/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Задача №10");
Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());
if ((Number>=100) && (Number<1000))
{
    Number  = (Number/10)%10;
}
Console.WriteLine(Number); 

/*Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Задача №13");
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
if (Number <100)
{
    Console.WriteLine("Третьей цифры нет!");
}
if (Number>999)
{
    Number = Number / 10;
}
    Console.WriteLine($"Третья цифра - {Number%10}");*/

    /*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Задача №15");
Console.WriteLine("Введите цифры, обозначающие дни недели: 1 ,2, 3, 4, 5, 6, 7");
int DayWeek= int.Parse(Console.ReadLine());

if (DayWeek>5)
{
   Console.WriteLine($"ДА -выходной {"cуббота, воскресенье"}");  
}
if (DayWeek<=5)
{
    Console.WriteLine("НЕТ-Не выходной");  
}
