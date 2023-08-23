
//Создайте Semaphore, осуществляющий контроль доступа к ресурсу из нескольких потоков.
//Организуйте упорядоченный вывод информации о получении доступа в специальный файл log.txt.  

public class Program
{
    private static Semaphore semaphore;

    public static void Main()
    {
        semaphore = new Semaphore(1, 2, "MySemaphoreE1B58820-0D2F-4CB6-8B1D-EBD840641203");

        for (int i = 0; i < 5; i++)
        {
            Thread thread = new Thread(Function);
            thread.Start(thread.ManagedThreadId);
        }
        Console.ReadKey();
    }

    static void Function(object id)
    {
        semaphore.WaitOne();
        StreamWriter streamWriter = new StreamWriter(@"D:\Testing\log.txt", true);
        streamWriter.WriteLine("Поток с id: {0}", id);
        streamWriter.Close();
        semaphore.Release();
    }
}