
//Начальный вклад в банке равен 1000 руб.
//Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы.
//По данному P определить, через сколько месяцев размер вклада превысит 1100 руб.,
//и вывести найденное количество месяцев K и итоговый размер вклада S
//(Итоговый размер вклада вывести максимально точно).

while (true)
{
    InitialBankDeposit();
}


static void InitialBankDeposit()
{
    decimal contribution = 1000;
    decimal percent = 0;
    int countMonths = 0;

    Console.WriteLine("Введите процент вклада");
    percent = IsDigit();
    Console.WriteLine();

    do
    {
        contribution += (contribution * percent) / 100;
        countMonths++;

    } while (contribution < 1100);

    Console.WriteLine($"С суммой 1000 под {percent} процентов");
    Console.WriteLine($"потребовалось {countMonths} месяцев что бы достигнуть суммы в {contribution}");
}



static decimal IsDigit()
{
    decimal digit;
    bool isDigit = false;
    do
    {
        isDigit = decimal.TryParse(Console.ReadLine(), out digit);
    } while (!isDigit);
    return digit;
}