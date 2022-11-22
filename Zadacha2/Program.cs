// Напишите программу которая принимат трехзначное число а на выходе показывает последнюю цифру этого числа 
Console.Clear();
Console.WriteLine("Введите число ");
int n1 = int.Parse(Console.ReadLine());
int n2 = n1%10;
Console.WriteLine(n2);