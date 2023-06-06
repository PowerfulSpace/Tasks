

//                             Задача
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте четыре метода для выполнения арифметических операций,
//с именами: Add – сложение, Sub – вычитание, Mul – умножение,
//Div – деление. Каждый метод должен принимать два целочисленных аргумента
//и выводить на экран результат выполнения арифметической операции соответствующей имени метода.
//Метод деления Div, должен выполнять проверку попытки деления на ноль.
//Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак  
//арифметической операции, для выполнения вычислений.  


while (true)
{
    ArithmeticOperation();
}


static void ArithmeticOperation()
{
    Console.WriteLine("Напиши арифмитическую операцию");
    int digitOne = IsDigit();
    char sign = IsSign();
    int digitThwoo = IsDigit();

    int result = 0;

    switch (sign)
    {
        case '+':
            result = Add(digitOne, digitThwoo);
            break;
        case '-':
            result = Sub(digitOne, digitThwoo);
            break;
        case '*':
            result = Mul(digitOne, digitThwoo);
            break;
        case '/':
            result = Div(digitOne, digitThwoo);
            break;
        default:
            break;
    }
    Console.WriteLine("Результат: {0}",result);
}

static int Add(int digitOne,int digitThwoo)
{
    return digitOne + digitThwoo;
}
static int Sub(int digitOne, int digitThwoo)
{
    return digitOne - digitThwoo;
}
static int Mul(int digitOne, int digitThwoo)
{
    return digitOne * digitThwoo;
}
static int Div(int digitOne, int digitThwoo)
{
    if(digitThwoo == 0) { return 0; }
    return digitOne / digitThwoo;
}

static int IsDigit()
{
    int digit;
    bool isDigit;
    do
    {
        isDigit = int.TryParse(Console.ReadLine(), out digit);
    } while (!isDigit);
    return digit;
}

static char IsSign()
{
    char sign;
    bool isSign = false;
    bool isSignArithmeticOperation = false;
    do
    {
        isSign = char.TryParse(Console.ReadLine(), out sign);
        isSignArithmeticOperation = false;

        switch (sign)
        {
            case '+':
                isSignArithmeticOperation = true;
                break;
            case '-':
                isSignArithmeticOperation = true;
                break;
            case '*':
                isSignArithmeticOperation = true;
                break;
            case '/':
                isSignArithmeticOperation = true;
                break;
            default:
                break;
        }

    }
    while (!isSign || !isSignArithmeticOperation);

    return sign;
}












