Public class linqStuff{
[Fact]
public void Test1()
{
int [] input = {1,2,3,4,5,6,7,8,9,10 };
string result = LinqQ.evenNumbers({input});
Assert.Contains(int{2 4,6,8,10}, result);
}
[Fact]
public void Test2()
{
int [] input = {1,2,3,4,5,6,7,8,9,10 };
string result = LinqQ.evenNumDec({input});
Assert.Contains(int{10, 8, 6, 4, 2}, result);
}
[Fact]
public void Test3()
{
int [] input = { 10, 25, 47, 55, 60, 78, 90, 100 };
string result = LinqQ.sum50({input});
Assert.Contains(389, result);
}
}