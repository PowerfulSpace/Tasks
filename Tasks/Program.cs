
//                                      Задача
//Написать программу, которая считает среднее арифметическое трех чисел введенных с клавиатуры.


AverageOfThreeNumbers();

Console.ReadKey();



static void AverageOfThreeNumbers()
{
    var digits = Enter();
    var sum = (digits.Item1 + digits.Item2 + digits.Item3) / 3;
    Console.WriteLine("-------");
    Console.WriteLine($" Первое число: {digits.Item1} Второе число: {digits.Item2} Третье число: {digits.Item3} Сумма: {sum:F2}");
}

static double IsDigits()
{
    double digit;
    bool isDigit = true;
    do
    {
        isDigit = double.TryParse(Console.ReadLine(), out digit);
    } while (!isDigit);
    return digit;
}

static (double, double, double) Enter()
{
    Console.WriteLine("Введите первое число");
    double digit1 = IsDigits();
    Console.WriteLine("Введите второе число");
    double digit2 = IsDigits();
    Console.WriteLine("Введите третье число");
    double digit3 = IsDigits();

    return (digit1, digit2, digit3);
}