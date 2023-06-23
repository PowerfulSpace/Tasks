

//Дано значение температуры T в градусах Фаренгейта.
//Определить значение этой же температуры в градусах Цельсия.
//Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением:
//TC = (TF – 32)·5 / 9.



while (true)
{
    TemperatureConversionFromFahrenheitToCelsius();
}

static void TemperatureConversionFromFahrenheitToCelsius()
{
    int tempF = 0;
    int tempC = 0;

    Console.WriteLine("Введите температуру в фаренгейтах");
    tempF = IsDigit();
    tempC = (tempF - 32) * 5 / 9;
    Console.WriteLine("Температуара - " + tempC);
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
































