
//Написать программу расчета объема V и площади S поверхности цилиндра.
//Данные вводимые с клавиатуры: радиус цилиндра R и высота цилиндра H. Формулы для расчета:
//V=πR^2 H; 
//S=2πR^2+2πRH; 


CylinderArea();
Console.ReadLine();


static void CylinderArea()
{
    var digits = Enter();
    double R = digits.Item1;
    double H = digits.Item2;
    double V = ((Math.PI * R) * 2) * H;
    double S = (2 * Math.PI * R * 2) + (2 * Math.PI * R * H);
    Show(R, H, V, S);
}

static double IsDigit()
{
    double digit;
    bool isDigit = false;
    do
    {
        isDigit = double.TryParse(Console.ReadLine(), out digit);

    } while (!isDigit);
    return digit;
}

static (double,double) Enter()
{

    Console.WriteLine("Введите радиус цилиндра:");
    double R = IsDigit();
    Console.WriteLine("Введите Высоту цилиндра:");
    double H = IsDigit();

    Console.WriteLine($"Радиус: {R}, Высота: {H}");

    return (R,H);
}

static void Show(double r, double h, double v, double s)
{
    Console.Clear();
    Console.WriteLine("Площади цилиндра");
    Console.WriteLine($"Радиус = {r}, Высота = {h}, Обьём = {v:F2}, Площадь = {s:F2}");
}