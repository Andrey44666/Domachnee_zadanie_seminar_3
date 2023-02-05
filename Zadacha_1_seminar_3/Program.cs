// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
int N = 0;
int default_number = number;
while (number > 0) 
{
   N *= 10;     
   N += number % 10;
   number /= 10;
}
Console.WriteLine(N);
if (N == default_number)
{
   Console.Write("number palindrome");
}
else
{
   Console.Write("number not palindrome");   
}