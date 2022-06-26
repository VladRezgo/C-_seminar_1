// Напишите программу, которая принимает на вход трехразное число, а на выходе показывает последнее число
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n <= 999)
{
Console.WriteLine(n%10);
}
else { Console.WriteLine("Error");
}