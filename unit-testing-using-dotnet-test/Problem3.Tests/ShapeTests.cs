public class ShapeTests
{
[Fact]
public void TestCircleArea()
{
Circle circle = new Circle(5);
double expectedArea = Math.PI * 5 * 5; // π * r^2
double actualArea = circle.Area();
Assert.Equal(expectedArea, actualArea, 6); // 6 decimal places
}

[Fact]
public void TestRectangleArea()
{
Rectangle rectangle = new Rectangle(4, 6);
double expectedArea = 4 * 6; // width * height
double actualArea = rectangle.Area();
Assert.Equal(expectedArea, actualArea);
}
[Fact]
public void TestTriangleArea()
{
Triangle triangle = new Triangle(3, 7);
double expectedArea = 0.5 * 3 * 7; // 0.5 * base * height
double actualArea = triangle.Area();
Assert.Equal(expectedArea, actualArea, 6); // 6 decimal places
}
}