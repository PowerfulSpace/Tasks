
//Даны целые положительные числа A, B, C.
//Значение этих чисел программа должна запрашивать у пользователя.
//На прямоугольнике размера A*B размещено максимально   возможное   количество   квадратов   со стороной C.
//Квадраты не накладываются друг на друга.
//Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.
//Необходимо предусмотреть служебные сообщения в случае,
//если в прямоугольнике нельзя разместить ни одного квадрата со стороной С.




NumberOfSquares();
Console.ReadLine();


static void NumberOfSquares()
{
    var size = EnterSize();
    int a = size.Item1;
    int b = size.Item2;
    int c = size.Item3;

    Console.Clear();
    Console.WriteLine($"Числа Ширина A = {a}, Высота B = {b}, размер квадрата C = {c}");

    int[,] rectangle = new int[a,b];

    Show(rectangle);

    int x = a / c;
    int y = b / c;

    int countRectangle = x * y;

    Console.WriteLine($"Количество квадратов: {countRectangle}");;
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

static (int,int,int) EnterSize()
{
    Console.WriteLine("Введите ширину прямоугольника A :");
    int a = IsDigit();
    Console.WriteLine("Введите высоту прямоугольника B :");
    int b = IsDigit();
    Console.WriteLine("Введите размер сторон квадрата C :");
    int c = IsDigit();
    return (a,b,c);
}

static void Show(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(" -- ");
        }
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write("| | ");
        }
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(" -- ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
