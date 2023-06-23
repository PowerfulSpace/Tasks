

//Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3).
//Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости: 
//D = формула для нахождения переметра
//Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: 
//S = (p·(p – a)·(p – b)·(p – c))1 / 2,
//где p = (a + b + c) / 2 — полупериметр.


PointCoordinatesthod();
Console.ReadLine();

static void PointCoordinatesthod()
{
    var points = EnterPointCoordinates();

    double p = 0;
    double s = 0;

    double a = 0;
    double b = 0;
    double c = 0;

    double x1 = points.x1;
    double x2 = points.x2;
    double x3 = points.x3;
    double y1 = points.y1;
    double y2 = points.y2;
    double y3 = points.y3;

    a = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
    b = Math.Sqrt(Math.Pow(x3 - x2,2) + Math.Pow(y3 - y2,2));
    c = Math.Sqrt(Math.Pow(x1 - x3,2) + Math.Pow(y1 - y3,2));

    p = (a + b + c) / 2;

    s = (p * (p - a) * (p - b) * (p - c)) / 2;

    Console.WriteLine(new string('-',30));
    Console.WriteLine($"Сторона a = {a}");
    Console.WriteLine($"Сторона b = {b}");
    Console.WriteLine($"Сторона c = {c}");
    Console.WriteLine($"Полупириметр = {p}");
    Console.WriteLine($"Площадь равна = {s}");
}



static int IsDigit()
{
    int digit;
    bool isDigit = false;
    do
    {
        isDigit = int.TryParse(Console.ReadLine(), out digit);
    } while (!isDigit);
    return digit;
}

static (int x1, int x2, int x3, int y1, int y2, int y3) EnterPointCoordinates()
{
    Console.WriteLine("Введите координату x1: ");
    int x1 = IsDigit();
    Console.WriteLine("Введите координату x2: ");
    int x2 = IsDigit();
    Console.WriteLine("Введите координату x3: ");
    int x3 = IsDigit();
    Console.WriteLine("Введите координату y1: ");
    int y1 = IsDigit();
    Console.WriteLine("Введите координату y2: ");
    int y2 = IsDigit();
    Console.WriteLine("Введите координату y3: ");
    int y3 = IsDigit();
    return (x1, x2, x3, y1, y2, y3);
}


