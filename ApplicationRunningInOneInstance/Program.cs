
//Создайте приложение, которое может быть запущено только в одном экземпляре (используя именованный Mutex). 


public class Program
{
    private static Mutex mutex;

    public static void Main()
    {
        mutex = new Mutex(false, "MyMutexF9E17019-A877-462C-8CDB-6896B3ECA315");

        var threads = new Thread[25];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(Function)
            {
                Name = i.ToString()
            };
            threads[i].Start(threads[i].ManagedThreadId);
        }

        Console.ReadKey();
    }

    static void Function(object id)
    {
        mutex.WaitOne();
        Console.WriteLine("Поток с id: {0}", id);
        Thread.Sleep(1000);
        mutex.ReleaseMutex();
    }
}