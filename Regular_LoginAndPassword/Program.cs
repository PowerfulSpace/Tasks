
//Напишите консольное приложение, позволяющие пользователю зарегистрироваться под «Логином»,
//состоящем только из символов латинского алфавита, и пароля, состоящего из цифр и символов.



using System.Text.RegularExpressions;



Registration();

Console.ReadLine();

static void Registration()
{
    string patternLogin = @"^[a-zA-Zа-яА-Я]+$";
    string patternPassword = @"^\w+$";

    Regex regexLogin = new Regex(patternLogin);
    Regex regexPassword = new Regex(patternPassword);

    string login = string.Empty;
    string password = string.Empty;
    bool flag = false;
    do
    {
        Console.Clear();
        Console.WriteLine("Введите логин");
        login = Console.ReadLine();

        if (regexLogin.IsMatch(login))
        {
            Console.WriteLine("Введите пароль");
            password = Console.ReadLine();
            if (regexPassword.IsMatch(password))
            {
                flag = true;
            }
            else
            {
                Console.WriteLine("пароль должен быть состоящим из цифр и символов");
                continue;
            }
        }
        else
        {
            Console.WriteLine("логин должен быть состоящем только из символов латинского алфавита");

        }

    } while (!flag);

    Console.WriteLine("Ваш логин: {0}", login);
    Console.WriteLine("Ваш пароль: {0}", password);
}

class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;
}