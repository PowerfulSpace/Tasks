
//Создайте консольное приложение, которое в различных потоках сможет получить доступ к 2-м файлам.
//Считайте из этих файлов содержимое и попытайтесь записать полученную информацию в третий файл.
//Чтение/запись должны осуществляться одновременно в каждом из дочерних потоков.
//Используйте блокировку потоков для того, чтобы добиться корректной записи в конечный файл.  


class Program
{
    static object locker = new object();
    static void Main()
    {
        Thread[] threads = new Thread[5];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(function);
            threads[i].Start();
        }

        Console.ReadLine();

    }
    static void function()
    {
        lock (locker)
        {
            using StreamReader streamReader1 = new StreamReader(@"D:\Testing\Test1.txt");
            string result1 = streamReader1.ReadToEnd();

            using StreamReader streamReader2 = new StreamReader(@"D:\Testing\Test2.txt");
            string result2 = streamReader2.ReadToEnd();

            using StreamWriter streamWriter = new StreamWriter(@"D:\Testing\Test3.txt", true);
            streamWriter.WriteLine("\n");
            streamWriter.WriteLine(result1);
            streamWriter.WriteLine(result2);
        }

    }
}






