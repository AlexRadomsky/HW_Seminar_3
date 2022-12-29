using System;

class Program {
  public static void Main (string[] args) {
  // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Console.WriteLine("Enter a number:"); 
try {
	int number = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Number\tCube");
	for (int i = 1; i <= number; i++) {
		Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
	}
} catch (Exception e) {
	Console.WriteLine(e.Message);
}
  }
}