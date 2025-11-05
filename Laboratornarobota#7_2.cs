using System;

class Fruit   
{
    public string name = "Це фрукт";
    
}

class Apple : Fruit{
    public new string name = "Яблуко";
    public string Variety = "Голден";  
    public string Color = "Жовте";  
}
class Peart : Fruit{
    public new string name = "Груша";
    public string Variety = "Зимна";  
    public string Color = "Зелена";  
}

class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Apple();
        Console.WriteLine($"{apple.name}: {apple.Variety}, {apple.Color}");

        Peart pear = new Peart();
        Console.WriteLine($"{pear.name}: {pear.Variety}, {pear.Color}");
    }
}
