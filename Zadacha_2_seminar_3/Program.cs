// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Enter number X1 ");
double numX1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number Y1 ");
double numY1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number X2 ");
double numX2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number Y2 ");
double numY2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());
double numSQRT = Math.Sqrt(Math.Pow((numX1 - numX2),2) + Math.Pow((numY1 - numY2),2) + Math.Pow((numZ1 - numZ2),2));
System.Console.Write(numSQRT);
