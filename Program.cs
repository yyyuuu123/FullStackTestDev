using TestApp;
using TestApp.Exeptions;
using TestApp.Model;

Figure circle = new Circle(5);
double circleArea = circle.GetArea();
Console.WriteLine($"Площадь круга: {circleArea}");

Figure triangle = new Tringle(3, 4, 5);
double triangleArea = triangle.GetArea();
Console.WriteLine($"Площадь треугольника: {triangleArea}");

bool isRightTriangle = Tringle.IsRightTriangle(3, 4, 5);


////Вычисление площади фигуры без знания типа фигуры в compile-time
//Не совсем понял что требуется, но Можно по наименованию другому селектору если такой появится проверять. 
//Надесь Я правильно понял. А иначе Я не совсем понимаю каким образом в момент компиляции мы можем определить.
//Буду рад на обратную связь


List<Figure> figures = new List<Figure>(2);
figures.Add(triangle);
figures.Add(circle);

foreach (Figure item in figures)
{
    try
    {
        double getShapeCompileTime = CompileTime<Figure>.GetInCompleTime(item);
        Console.WriteLine(getShapeCompileTime);
    }
    catch (NotFoundompileTime ex)
    {

        Console.WriteLine(ex.Output);
    }
}

