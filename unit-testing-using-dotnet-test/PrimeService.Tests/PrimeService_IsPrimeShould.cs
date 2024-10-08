using Xunit;
//using Prime.Services;

namespace Prime.UnitTests.Services
{
 public class Testprime{

    [Fact]
    public void Test1()
    {
        int[] numbers = {1, 0, -5 };
        foreach (var number in numbers)
        {
            bool result = PrimeService.IfPrime(number);
            Assert.False( result);
        }
    }

    [Fact]
    public void Test2()
    {
        string result = PrimeService.primeNumList(12);
        Assert.Contains("2 3 5 7 11", result.Trim());
    }
}

}