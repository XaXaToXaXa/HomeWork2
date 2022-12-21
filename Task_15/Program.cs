// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

//Simple way
// Console.WriteLine ("Введите число");
// int num = Convert.ToInt32 (Console.ReadLine());
// if (num == 6 || num == 7) 
// {
//     Console.WriteLine ("Weekeend!!!");
// }
// else 
// {
// Console.WriteLine("Boringday");
// }
Console.WriteLine ("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());
if ( num % 7  == 0 || (num + 1) % 7 == 0)  
{
    Console.WriteLine ("Weekeend!!!");
}
else 
{
Console.WriteLine("Boringday");
}