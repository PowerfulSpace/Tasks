

//Пользователь вводит текст, строку для поиска и строку для замены.
//Реализовать поиск в тексте заданной строки и замены ее на заданную подстроку. 



SearchTextReplacement();
Console.ReadLine();


static void SearchTextReplacement()
{
    string text;
    string search;
    string replace;

    bool isSearch = false;

    //Console.WriteLine("Введите текст");
    //text = Console.ReadLine();
    //Console.WriteLine("Введите слово которое хотите заменить");
    //search = Console.ReadLine();
    //Console.WriteLine("Введите слово на которое хотите заменить");
    //replace = Console.ReadLine();


    text = "У лукоморья дуб зелёный;\r\nЗлатая цепь на дубе том:\r\nИ днём и ночью кот учёный\r\nВсё ходит по цепи кругом;";
    search = "цепь";
    replace = "Цепуха";

    Console.WriteLine(text);
    Console.WriteLine();

    isSearch = text.Contains(search);
    if (isSearch)
    {
        text = text.Replace(search, replace);
    }

    Console.WriteLine(text);

}