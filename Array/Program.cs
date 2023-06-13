
WorkingWithAnArray();
Console.ReadLine();


static void WorkingWithAnArray()
{
    Console.WriteLine("Введите длину массива");
    int arrayLength = IsDigit();
    int[] array = RandomArray(arrayLength);
    ShowArray(array);

    Console.WriteLine("Минимальное число в массиве: {0}", array.Min());
    Console.WriteLine("Максимальное число в массиве: {0}",array.Max());
    Console.WriteLine("Общая сумма чисел в массиве: {0}", TotalSumInArray(array));
    Console.WriteLine("Среднее арифмитическое в массиве: {0}", ArithmeticMeanInArray(array));
    Console.WriteLine("Все нечётные числа в массиве:");
    ShowArray(AllOddNumbersInTheArray(array));
}

static int TotalSumInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

static int ArithmeticMeanInArray(int[] array)
{
    int sum = 0;
    int average = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    if (array.Length != 0)
    {
        average = sum / array.Length;
    }
    return average;
}

static int[] AllOddNumbersInTheArray(int[] array)
{
    List<int> oddNumberArray = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            oddNumberArray.Add(array[i]);
        }
    }
    return oddNumberArray.ToArray();
}

static int[] RandomArray(int length)
{
    var array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1,100);
    }
    return array;
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
static void ShowArray(int[] array)
{
    Console.WriteLine(new string('-', 10) + ">");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine(new string('-',10) + ">");
}

