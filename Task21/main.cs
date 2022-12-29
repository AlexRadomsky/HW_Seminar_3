using System;

class Program {
  public static void Main (string[] args) {
   // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
Console.Write("Enter the coordinate х1: "); 
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the coordinate y1: "); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the coordinate z1: "); 
int z1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the coordinate x2: "); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the coordinate y2: "); 
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter the coordinate z2: "); 
int z2 = Convert.ToInt32(Console.ReadLine()); 
 
double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);  
 
Console.WriteLine($"Distance between 2 points: {d}");
  }
}