public class ContainsOrNo{
[Fact]
public void Test1()
{
string[] arrayy= { "home", "milk", "Mercury", "fish"};
string one = "me";
String[] result = SubstringContains.substrings(given,find);
Assert.Equal(string[] {“home”, “Mercury”}, result);
}
[Fact]
public void Test2()
{
string[] arrayy= { "home", "milk", "Mercury", "fish"};
string one = "sh";
String[] result = SubstringContains.substrings(arrayy,one);
Assert.Equal(string[] {"fish"}, result);
}
}