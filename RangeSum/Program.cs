
//Задача
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Дано два числа A и B (A<B) выведите суму всех чисел
//расположенных между данными числами на экран. Дано два числа A и B (A<B)
//выведите все нечетные значения, расположенные между данными числами.  







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