using System;
using System.Collections.Generic;

abstract class Shape{
public abstract double Area(); //this abstract class has method area(), so any class that
//inherits from this must provide its own implementation to calculate areaa
}
class Circle : Shape{
public double Radius { get; set; }
public Circle(double radius)
{
Radius = radius;
}
public override double Area() {
return Math.PI * Radius * Radius; // Area of a circle: π * r^2
}
}
//The circle class inherits from shape and has a radius property.This class overrides the area
//method to calculate area of circle using its formula
class Rectangle : Shape{
public double Width { get; set; }
public double Height { get; set; }
public Rectangle(double width, double height) {
Width = width;
Height = height;
}
public override double Area(){
return Width * Height; // Area of a rectangle: width * height
}
}
//The rectangle class inherits from shape and has height and width properties.This class
//overrides the area method to calculate area of circle using its formula
class Triangle : Shape{
public double Base { get; set; }
public double Height { get; set; }
public Triangle(double baseLength, double height){
Base = baseLength;
Height = height;
}
public override double Area(){
return 0.5 * Base * Height; // Area of a triangle: 0.5 * base * height
}
}
//The triangle class inherits from shape and has height and base properties.This class
//overrides the area method to calculate area of circle using its formula

class Program{
public static void Main(string[] args){
// Create a list of shapes (polymorphism in action)
List<Shape> shapes = new List<Shape>{
new Circle(5), // Circle with radius 5
new Rectangle(4, 6), // Rectangle with width 4 and height 6
new Triangle(3, 7) // Triangle with base 3 and height 7
};
// Iterate over the collection of shapes and print their areas
foreach (Shape shape in shapes){
Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.Area()}");
}
}
}
//here, override means that the methods in a derived class are providing a specific
//implementation of a method that was defined as abstract in the base class (Shape). The
//Area() method is abstract in Shape, which means it has no implementation there. Each
//derived class (e.g., Circle) must use override to give its own version of how to calculate the
//area, tailored to the specific shape it represents.
//polymorphism allows objects from different classes to be treated as objects of base class,
//exactly what is happening here
//I went through cs142 slides and took help from chatgpt to do and properly understand the
//syntax for this.
//Cite: https://chatgpt.com/share/6703b62d-9fb0-8008-b5fc-8317cbdf7084