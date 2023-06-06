
//Задача
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Дано два числа A и B (A<B) выведите суму всех чисел
//расположенных между данными числами на экран. Дано два числа A и B (A<B)
//выведите все нечетные значения, расположенные между данными числами.  

RangeSum();
Console.ReadLine();

static void RangeSum()
{
    var digits = Enter();
    var next = digits.Item1;
    var last = digits.Item2;

    List<double> allDigits = new List<double>();
    double sum = 0;

    for (double i = next + 1; i < last; i++)
    {
        sum += i;
        allDigits.Add(i);
    }
    List<double>  noEventNumbers = ParityCheck(allDigits);

    Show(allDigits, "\nЧисла попавшие под диапазон");
    Show(noEventNumbers, "\nНечётные числа попавшие под диапазон");
    Console.WriteLine("\nСумма чисел попавших под диапазон: \n{0}", sum);
}

static List<double> ParityCheck(List<double> digits)
{
    List<double> noEventNumbers = new List<double>();
    foreach (var item in digits)
    {
        if (item % 2 == 0 && item != 0)
        {
            noEventNumbers.Add(item);
        }
    }
    return noEventNumbers;
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

static (double, double) Enter()
{
    Console.WriteLine("Введите 2 числа");
    Console.WriteLine("Введите число A");
    var A = IsDigit();
    Console.WriteLine("Введите число B");
    var B = IsDigit();
    if (A > B)
    {
        double a = B;
        B = A;
        A = a;
    }

    return(A, B);
}

static void Show(List<double> digits, string name)
{
    Console.WriteLine(name);
    foreach (var item in digits)
    {
        Console.Write(item + " ");
    }
}