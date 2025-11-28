using System;

class Person
{
    private string name;
    private int age;

    public void SetName(string n)
    {
        name = n;
    }

    public void SetAge(int a)
    {
        age = a;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
}

class Encapsulation
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.SetName("Alex");
        p.SetAge(22);

        Console.WriteLine(p.GetName());
        Console.WriteLine(p.GetAge());

        Console.ReadLine();
    }
}
