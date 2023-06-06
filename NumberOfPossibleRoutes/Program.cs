
//Задача
//Имеется N клиентов, которым компания производитель должна доставить товар.
//Сколько существует возможных маршрутов доставки товара, с учетом того,
//что товар будет доставлять одна машина? Используя Visual Studio,
//создайте проект по шаблону Console Application. Напишите программу,
//которая будет рассчитывать, и выводить на экран количество возможных вариантов доставки товара.  


NumberOfPossibleRoutes();

Console.ReadLine();


static void NumberOfPossibleRoutes()
{
    Console.WriteLine("Введите количество клиентов");
    int countClients = IsDigits();
    int countRoutes = 0;

    for (int i = 0; i < countClients; i++)
    {
        countRoutes += countClients - i;
    }
    Console.WriteLine("Количество клиентов: {0} потанциальных маршутов: {1}", countClients,countRoutes);

}

static int IsDigits()
{
    int digits;
    bool isDigits = false;
    do
    {
        isDigits = int.TryParse(Console.ReadLine(), out digits);
    } while (!isDigits);
    return digits;
}




