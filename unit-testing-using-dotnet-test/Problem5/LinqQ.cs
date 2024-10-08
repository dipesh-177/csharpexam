using System;
using System.Linq;
using System.Collections.Generic;
public class linqQ
{
//so how linq works is, first ww start with a list/ array and then we write the linq syntax and
//use method like .where() or.select() according to what we want it to do and executle it and
//during this process we also write where we want the new elements of the list/array to go by
//using the .ToList(), .To Array() and this result from linq after collect the separated data as per
//out conditions can now be used as per what the program intends to do

public static void Main(string[] args)
{
//calling all method in the main function
evenNumbers();
evenNumDec();
sum50();
}
//to find even numbers
public static void evenNumbers()
{
List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//use LINQ to find even numbers
var even = numList.Where(n => n % 2 == 0)

.ToList();

//join the result into a string and print it
string final = string.Join(", ", even);
Console.WriteLine("Even numbers: " + final);
}
// to find even numbers and sort them in descending order
public static void evenNumDec()
{
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// Use LINQ to find even numbers and order them by descending order
var evenNumbers = numbers.Where(n => n % 2 == 0)
.OrderByDescending(n => n)
.ToList();

//join the result into a string and print it
string final = string.Join(", ", evenNumbers);
Console.WriteLine("Even numbers in descending order: " + final);
}
//to find the sum of numbers greater than 50
public static void sum50()
{
List<int> numbers = new List<int> { 10, 25, 47, 51, 70, 73, 95, 100 };
//use LINQ to find numbers greater than 50 and calculate their sum
int sum = numbers.Where(n => n > 50)

.Sum();

//print the sum of numbers greater than 50
Console.WriteLine("Sum of numbers greater than 50: " + sum);

}
}