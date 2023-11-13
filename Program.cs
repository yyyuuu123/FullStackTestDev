using TestApp;
using TestApp.Model;

Figure circle = new Circle(5);
double circleArea = circle.GetArea();
Console.WriteLine($"Площадь круга: {circleArea}");

Figure triangle = new Tringle(3, 4, 5);
double triangleArea = triangle.GetArea();
Console.WriteLine($"Площадь треугольника: {triangleArea}");