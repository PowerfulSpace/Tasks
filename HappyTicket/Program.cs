
//Ввести с клавиатуры номер трамвайного билета (6-значное число)
//и проверить является ли данный билет счастливым
//(если на билете напечатано шестизначное число,
//и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).

EnterTicket();

Console.ReadKey();

static void EnterTicket()
{
    int digit = 0;
    bool RequiredLengthDigit = false;
    bool isHappyTicket = false;

    do
    {
        Console.WriteLine("Введите 6 значное число");
        digit = IsDigit();
        RequiredLengthDigit = IsLengthDigit(digit);
        if (RequiredLengthDigit != true) { Console.Clear(); }
    } while (!RequiredLengthDigit);

    isHappyTicket = IsHappyTicket(digit);

    if (isHappyTicket)
    {
        Console.WriteLine("У вас счастливый билет");
    }
    else
    {
        Console.WriteLine("Обычный билет");
    }

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

static bool IsLengthDigit(int digit)
{
    var lengthDigit = digit.ToString();
    bool isLengthDigit = lengthDigit.Length == 6;
    return isLengthDigit;
}

static bool IsHappyTicket(int digit)
{
    string stringDigit = digit.ToString();
    int leftSideOfTheNumber = 0; 
    int rightSideOfTheNumber = 0;

    for (int i = 0; i < 6; i++)
    {
        if (i < 3)
            leftSideOfTheNumber += (int)Char.GetNumericValue(stringDigit[i]);
        else
            rightSideOfTheNumber += (int)Char.GetNumericValue(stringDigit[i]);
    }
    
    return leftSideOfTheNumber == rightSideOfTheNumber;
}



static void Test()
{
    List<char> charDigits = new List<char>();
    char key = char.MinValue;
    int mychar;

    do
    {
        do
        {
            key = Console.ReadKey().KeyChar;
            mychar = (int)Char.GetNumericValue(key);

        } while (mychar == -1);

        charDigits.Add(key);

    } while (charDigits.Count != 6);
}












