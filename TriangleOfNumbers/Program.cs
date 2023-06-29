


//Даны целые положительные числа A и B (A<B). Вывести все целые числа от A до B  включительно;
//каждое число должно выводиться на новой строке; при этом каждое  число должно выводиться количество раз,
//равное его значению. Например: если А = 3, а В =  7, то программа должна сформировать в консоли следующий вывод:

//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7




TriangleOfNumbers();
Console.ReadLine();

static void TriangleOfNumbers()
{
    int a = 0;
    int b = 0;


    Console.WriteLine("Введите число A");
    a = IsDigit();
    Console.WriteLine("Введите число B");
    b = IsDigit();

    for (int i = a; i <= b; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
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
