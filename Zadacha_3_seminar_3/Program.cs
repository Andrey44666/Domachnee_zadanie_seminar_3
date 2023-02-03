// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine());
int N = 1;
while (N <= number)
{
    System.Console.Write(N * Math.Pow(N, 3) + " ");
    N+=1;
}   
