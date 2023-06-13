
//Требуется:
//1) Создать метод MyReverse(int [] array), который принимает в качестве аргумента массив
//целочисленных элементов и возвращает инвертированный массив (элементы массива в обратном порядке).  

//2) Создайте метод int [] SubArray(int[] array, int index, int count).
//Метод возвращает часть полученного в качестве аргумента массива,
//начиная с позиции указанной в аргументе index, размерностью, которая соответствует
//значению аргумента count. Если аргумент count содержит значение больше чем количество элементов,
//которые входят в выбираемую часть исходного
//массива (от указанного индекса index, до индекса последнего элемента),
//то при формировании нового массива размерностью в count, заполните единицами те элементы,
//которые не были скопированы из исходного массива. 



//Реверс массива
Console.WriteLine("Введите длину рандомного массива");
var randomArray = RandomArray(IsDigit());
var reverseArray = MyReverse(randomArray);

Console.WriteLine(new string('-', 10));
Console.WriteLine("Массив");
ShowArray(randomArray);
Console.WriteLine("реверсированный Массив");
ShowArray(reverseArray);

//Подмассив
Console.WriteLine("введите index в массиве по которому будем делать выборку");
int index = IsDigit();
Console.WriteLine("введите какое количество элементов выбрать");
int count = IsDigit();
var subArray = SubArray(randomArray, index, count);

Console.WriteLine(new string('-', 10));
Console.WriteLine("Массив");
ShowArray(randomArray);
Console.WriteLine("Подм Массив");
ShowArray(subArray);

Console.ReadLine();


static int[] MyReverse(int[] array)
{
    return array.Reverse().ToArray();
}



static int[] SubArray(int[] array, int index, int count)
{
    List<int> newArray = new List<int>();
    int length = count + index;

    for (int i = index; i < length; i++)
    {
        if (i < array.Length)
            newArray.Add(array[i]);
        else
            newArray.Add(1);
    }
    
    return newArray.ToArray();
}










static int[] RandomArray(int length)
{
    var array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 100);
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
    Console.WriteLine(new string('-', 10) + ">");
}







