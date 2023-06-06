
//Задача
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.  Напишите метод, который будет определять:   
//  1) является ли введенное число положительным или отрицательным.   
//  2) Является ли оно простым (используйте технику перебора значений).   
//(Простое число — это натуральное число, которое делится на 1 и само на себя.
//Чтобы определить простое число или нет, следует найти все его целые делители.
//Если делителей больше 2-х, значит оно не простое.)  
//  3) Делится ли на 2, 5, 3, 6, 9 без остатка.  


while (true)
{
    IsPrimeNumber();
}



static void IsPrimeNumber()
{
    int digit = IsDigit();
    bool idPrime = false;
    if (digit == 1 || digit == 2) { idPrime = true; }
    for (int i = 2; i < digit; i++)
    {
        idPrime = true;
        if (digit % i == 0)
        {
            idPrime = false;
            break;
        }
    }

    if (idPrime) { Console.WriteLine($"Число {digit} является простым"); }
    else { Console.WriteLine($"-----------Число {digit} не является простым"); }
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
