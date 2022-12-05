// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

//Console.Write("Enter three-figure number ");
//int Num = int.Parse(Console.ReadLine());
//if ((100 <= Num) && (Num <= 999)) 
//{
//    int Num1 = Num % 100;
//    int Num2 = Num % 10;
//    int res = (Num1 - Num2) /10;
//    Console.WriteLine($"{res}");
//}
//else
//    Console.WriteLine("That's not three-figure number");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.Write("Enter number ");
//int Num = int.Parse(Console.ReadLine());
//while (Num > 999)
//{
//    Num = Num / 10;
//}
//if (100 <= Num) 
//{
//    int Num3 = Num % 10;
//    Console.WriteLine($"{Num3}");
//}
//else
//Console.WriteLine("No three figure");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
//день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Enter number from 1 t0 7: ");
int Num = int.Parse(Console.ReadLine());
if (Num <= 5)
{
    Console.WriteLine("not weekend(((");
}
else if ((Num >= 6) && (Num <=7))
{
    Console.WriteLine("Weekend!!!)))");
}
else
    Console.WriteLine("Choose figure from 1 to 7");