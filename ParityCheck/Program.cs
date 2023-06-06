
//                                   Задача
//Известно, что у четных чисел младший бит имеет значение 0. Используя Visual Studio,
//создайте проект по шаблону ConsoleApplication.  Напишите программу,
//которая будет выполнять проверку  чисел на четность.
//Предложите два варианта решения поставленной задачи.  


ParityCheck_FirstOption();
ParityCheck_SecondOption();
Console.ReadLine();






static void ParityCheck_FirstOption()
{
    int[] digits = DigitsGenerator(20);

    List<int> primeNumbers = new List<int>();
    for (int i = 0; i < digits.Length; i++)
    {
        if (digits[i] % 2 == 0 && digits[i] != 0)
        {
            primeNumbers.Add(digits[i]);
        }
    }

    Show(primeNumbers);
}
static void ParityCheck_SecondOption()
{
    int[] digits = DigitsGenerator(20);

    List<int> primeNumbers = new List<int>();

    for (int i = 0; i < digits.Length; i++)
    {
        if ((digits[i] & 1) == 0 && digits[i] != 0)
        {
            primeNumbers.Add(digits[i]);
        }
    }

    Show(primeNumbers);
}





static int[] DigitsGenerator(int count)
{
    List<int> digits = new List<int>();

	for (int i = 0; i <= count; i++)
	{
        digits.Add(i);
    }
    return digits.ToArray();
}

static void Show(List<int> array)
{
    Console.WriteLine("=-----------------------------=");
    foreach (var item in array)
    {
        Console.Write("{0} ", item);
    }
}