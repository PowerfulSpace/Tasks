
//Создайте пользовательский атрибут AccessLevelAttribute,
//позволяющий определить уровень доступа пользователя к системе.
//Сформируйте состав сотрудников некоторой фирмы в виде набора классов,
//например, Manager, Programmer, Director. При помощи атрибута AccessLevelAttribute
//распределите уровни доступа персонала и отобразите на экране реакцию системы
//на попытку каждого сотрудника получить доступ в защищенную секцию.  



CollectionOnEmp emp = new CollectionOnEmp();
emp.TryToAccess();


Console.ReadLine();



[AttributeUsageAttribute(AttributeTargets.All, AllowMultiple = false)]
class AccessLevelAttribute : Attribute
{
    public string Name { get; set; }
    public readonly int accessLevel;

    public AccessLevelAttribute(int accessLevel)
    {
        this.accessLevel = accessLevel;
    }
}

public class Employee
{
    public virtual void Method() { }
}


[AccessLevel(2, Name = "Вася")]
class Manager : Employee
{
    public override void Method()
    {
        Console.WriteLine("Manager");
    }
}
[AccessLevel(1, Name = "Петя")]
class Programmer : Employee
{
    public override void Method()
    {
        Console.WriteLine("Programmer");
    }
}
[AccessLevel(3, Name = "Руди")]
class Director : Employee
{
    public override void Method()
    {
        Console.WriteLine("Director");
    }
}

class CollectionOnEmp
{
    Employee[] employees = new Employee[3];
    public CollectionOnEmp()
    {
        employees[0] = new Manager();
        employees[1] = new Programmer();
        employees[2] = new Director();
    }

    public void TryToAccess()
    {
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Работник: {0}", employees[i].GetType().Name);
            employees[i].Method();
            Type type = employees[i].GetType();
            object[] attributes = type.GetCustomAttributes(false);
            foreach (AccessLevelAttribute att in attributes)
            {
                if (att.accessLevel == 1) Console.WriteLine("Отказано");
                if (att.accessLevel == 2) Console.WriteLine("Неполны йдоступ");
                if (att.accessLevel == 3) Console.WriteLine("Доступ разрешён");
            }
            Console.WriteLine();
        }
    }

}