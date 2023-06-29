

// Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево.
// Например, если было введено число 345,  то  программа должна вывести число 543.



NumberReverse();
Console.ReadLine();

static void NumberReverse()
{
    int number = 0;
    int numberReverse;
    char[] setOfNumber;
    string stringOfNumbers;

    Console.WriteLine("Введите число");
    number = IsDigit();
    Console.WriteLine();

    setOfNumber = number.ToString().ToCharArray();
    Array.Reverse(setOfNumber,0, setOfNumber.Length);

    stringOfNumbers = new string(setOfNumber);
    numberReverse = Convert.ToInt32(stringOfNumbers);

    Console.WriteLine(number);
    Console.WriteLine(numberReverse);
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



