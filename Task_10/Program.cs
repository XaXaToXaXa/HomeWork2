// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32 (Console.ReadLine());
int a = (num%100)/10;
Console.WriteLine(a);
