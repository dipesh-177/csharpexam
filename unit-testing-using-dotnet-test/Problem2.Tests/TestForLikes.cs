public class TestForLikes{
[Fact]
public void Test1()
{
string[] input = { };
string result = Likes.numOfLikes(input);
Assert.Equal("No one likes this", result);
}
[Fact]
public void Test2()
{
string[] input = {"Dipesh", "Adhikari", "Okay", "Sup" };
string result = Likes.numOfLikes(input);
Assert.Equal("Dipesh, Adhikari and 2 others like this", result);

}
[Fact]
public void Test3()
{
string[] input = {"Dipesh" };
string result =Likes.numOfLikes(input);
Assert.Equal("Dipesh likes this", result);
}
}