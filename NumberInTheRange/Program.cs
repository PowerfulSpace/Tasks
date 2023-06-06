
//                                   Задача
//Напишите программу определения, попадает ли указанное пользователем число от 0 до 100
//в числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, то укажите,
//в какой именно промежуток. Если пользователь указывает число не входящее
//ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.  


while (true)
{
    IsTheNumberInTheRange();
}



static void IsTheNumberInTheRange()
{
    var digit = IsDigit();
    if (digit >= 0 && digit <= 100)
    {
        if (digit >= 0 && digit <= 14)
        {
            Console.WriteLine("Число {0} в диапазоне от 0 до 14", digit);
        }
        else if (digit >= 15 && digit <= 35)
        {
            Console.WriteLine("Число {0} в диапазоне от 15 до 35", digit);
        }
        else if (digit >= 36 && digit <= 50)
        {
            Console.WriteLine("Число {0} в диапазоне от 36 до 50", digit);
        }
        else
        {
            Console.WriteLine("Число {0} в диапазоне от 51 до 100", digit);
        }
    }
    else
    {
        Console.WriteLine("Число вышло за диапазон");
    }
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


