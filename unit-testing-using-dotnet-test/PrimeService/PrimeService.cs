using System;


public class PrimeService{
public static void Main(string[] args) {
Console.WriteLine("Enter the number: ");//here we print this and ask the user for an
int num = int.Parse(Console.ReadLine());
bool primeNumber = IfPrime(num); //we are calling the ifPrime method and then printing
//it for user to see, if prime methods returns whether the number is prime or not(True/False)
Console.WriteLine(primeNumber);
string numbers = primeNumList(num);
Console.WriteLine(numbers);
}
public static bool IfPrime(int num) {
bool primeNumber = true;
if (num <= 1)
primeNumber = false; //if a number is 1 or less it is not prime
else {
// as 0 and 1 are not prime, we start our loop from 2 up until the sqroot of the number input
//by the user. If a number is not prime, it will always have at least one factor less than or equal
//to its square root and thats what we check in the loop
for (int i = 2; i <= Math.Sqrt(num); i++) {
if (num % i == 0) {
primeNumber = false;
break;
}
}
}
return primeNumber;
}

public static string primeNumList(int num) {
//the first loop gives num from 2 to number to the 2nd loop and the second loops checks if it
//is a prime or not and returns it
string numbers = "";
for (int i = 2; i <= num; i++) {
bool primeNum = true;
for (int j = 2; j <= Math.Sqrt(i); j++) {
if (i % j == 0) {
primeNum = false;
break;
}
}

if (primeNum) {
numbers += (i + " ");
}
}
return numbers;
}
}
