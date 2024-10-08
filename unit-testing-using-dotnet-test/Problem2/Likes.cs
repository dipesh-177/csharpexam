using System;
public class Likes{
public static void Main(string[] args) {
string[] name = {"Dipesh", "Adhikari", "Okay", "Sup"};
numOfLikes(name); // call function
}

public static void numOfLikes(string[] name) {
int count = name.Length;
//we can just use switch case for this

switch(count) {
case 0:
Console.WriteLine("No one likes this");
break;
case 1:
Console.WriteLine(name[0] + " likes this");
break;
case 2:
Console.WriteLine(name[0] + " and " + name[1] + " like this");
break;
case 3:
Console.WriteLine(name[0] + ", " + name[1] + " and " + name[2] + " like this");
break;
default:
Console.WriteLine(name[0] + ", " + name[1] + " and " + (name.Length - 2) + "others like this");
break;
}
}
}
//what switch case does is checks a variable (count in this case) and sees the length of value
//and “case” is used count+1 times(1 more time for default) . If theres a match with the
//condition of the case it runs it and if not it goes to the other case(like if else statements ) and
//if it cannot find any match, it goes over to the default statement.