// Created by: Ekaterina
// Created on: Nov 2022
//
// This program generates random positive or negative number

using System;

class Program
{
    public static void Main(string[] args)
    {
        int lengthA;
        int lengthB;
        int lengthC;
        double angleA;
        double angleB;
        double angleC;
        double sumOfAllAngles

        // This function accepts user input
        Console.WriteLine("What type of triangle is it?");
        Console.WriteLine(" ");

        Console.WriteLine("Enter the following length for each side: ");
        Console.WriteLine(" ");
        Console.WriteLine("Length A: ");
        lengthA = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Length B: ");
        lengthB = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(" ");
        Console.WriteLine("Length C: ");
        lengthC = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(" ");
        angleA = Math.Acos((Math.Pow(lengthB, 2) + Math.Pow(lengthC, 2) - Math.Pow(lengthA, 2)) / (2 * lengthB * lengthC)) * (180 / Math.PI);
        angleB = Math.Acos((Math.Pow(lengthC, 2) + Math.Pow(lengthA, 2) - Math.Pow(lengthB, 2)) / (2 * lengthC * lengthA)) * (180 / Math.PI);
        angleC = Math.Acos((Math.Pow(lengthA, 2) + Math.Pow(lengthB, 2) - Math.Pow(lengthC, 2)) / (2 * lengthA * lengthB)) * (180 / Math.PI);

      sumOfAllAngles = angleA + angleB + angleC;
      Console.WriteLine("Sum of all angles " + sumOfAllAngles.ToString("0.0"));
      Console.WriteLine(" ");  

  if (angleA == angleB && angleA == angleC) {
    Console.WriteLine("You have an equilateral triangle");
  } else if (angleA != angleB && angleA != angleC && angleB != angleC) {
    Console.WriteLine("You have an scalene triangle");
  } else if (angleA != angleB && angleA == angleC) {
    Console.WriteLine("You have an isosceles triangle");
  } else if (angleA == angleB && angleA != angleC) {
    Console.WriteLine("You have an isosceles triangle");
  } else if (angleC == angleB && angleA != angleC) {
    Console.WriteLine("You have an isosceles triangle");
  } else {
    Console.WriteLine("Not a triangle");
  }
    Console.WriteLine("\nDone.");
  }
}