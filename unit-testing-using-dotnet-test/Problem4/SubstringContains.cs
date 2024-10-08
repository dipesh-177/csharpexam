using System;
using System.Collections;
public class SubstringContains
{
public static  Main (string[] args) {
string[] given = {"home", "milk", "Mercury", "fish"}; // Present in the array that is given
string find = "me"; // Substring to find in the given array
// Call the new function to find substrings
substrings(given, find);

}
// Function to find substrings in the given array and print the result
public static string substrings(string[] given, string find) {
ArrayList neww = new ArrayList(); // Create a resizable array list, the length decreases
if we remove a element and increases if we add an element
for(int i = 0; i < given.Length; i++) { // Check every word in the array for if it contains
substring and if it does, add it to the resizable array list
string check = given[i].ToLower();
if(check.Contains(find.ToLower())) {
neww.Add(given[i]);
}
}
if(neww.Count < 1) {
Console.WriteLine("Empty"); // No matches found
} else {
string[] neww1 = new string[neww.Count]; // Create a new string array for storing the
results
int count = 0;
foreach(string str in neww) {

neww1[count] = str;
count++;
} //neww1, copies the elements from the collection into that array, and then prints
them
return Console.WriteLine(String.Join(", ", neww1)); // Print the results
}
}
}