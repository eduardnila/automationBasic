using System;

public class Hamster : IAnimal
{
    public string Name { get; set; }

    public void MakeNoise()
    {
        Console.WriteLine(Name + " says chit chit");
    }
    public string Eat()
    {
        return "carrots";
    }
}