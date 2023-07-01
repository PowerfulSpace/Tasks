
//Перемножение матриц
//Написатьп программу которая перемножает две матрицы, количество строк одной матрицы
//должны совпадать с количество столбцов второй матрицы


MatrixMultiplication();
Console.ReadLine();


static void MatrixMultiplication()
{
    var size = Enter();

    int array1x = size.Item1;
    int array1y = size.Item2;
    int array2x = size.Item3;
    int array2y = size.Item4;

    int[,] array1 = GetArrayRandomDigits(array1x, array1y);
    int[,] array2 = GetArrayRandomDigits(array2x, array2y);

    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];

    Show(array1);
    Console.WriteLine();
    Show(array2);


    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                //var x = array1[i, k];
                //var y = array2[k, j];
                //result[i, j] += x * y;
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    Console.WriteLine();
    Show(result);
}



static (int,int,int,int) Enter()
{
    Console.WriteLine("количество строк одной матрицы должны совпадать с количество столбцов второй матрицы");
    Console.WriteLine();
    Console.WriteLine("введите размер двум матрицам");

    Console.WriteLine("Первая матрица");
    Console.WriteLine("Количество строк:");
    int array1x = IsDigit();
    Console.WriteLine("Количество столбцов:");
    int array1y = IsDigit();

    Console.WriteLine("Вторая матрица");
    Console.WriteLine("Количество строк:");
    int array2x = IsDigit();
    Console.WriteLine("Количество столбцов:");
    int array2y = IsDigit();
    return (array1x, array1y, array2x, array2y);
}

static int[,] GetArrayRandomDigits(int column, int row)
{
    Random random = new Random();
    int[,] array = new int[column, row];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 5);
        }
    }
    return array;
}

static void Show(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
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

