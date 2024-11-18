
using System;
using System.Globalization;

class Person
{
    public string name;
    public int age;

    // public Person(string name, int a)
    // {
    //     name = name;
    //     age = a;

    // }
}

class Test
{
    public static void Main(string[] args)
    {

        Person p1 = new Person();
        p1.name = "Riaj Uddin";
        p1.age = 26;


        // before reference

        Console.WriteLine($"name= {p1.name},age= {p1.age}");
        Person p2 = p1;
        p2.age = 30;
        Console.WriteLine($"name={p2.name} , age = {p2.age}");
        ///After reference 
        Console.WriteLine($"name={p1.name} , age = {p1.age}");

    }
}
