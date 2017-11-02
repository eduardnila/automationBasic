using System;

public class Cat : IAnimal
{
    public string Name { get; set; }

    public void MakeNoise()
    {
        string noise = "miau miau";
        Console.WriteLine(Name + " says " + noise);
    }
    public string Eat()
    {
        string food = "mice";
        Console.WriteLine(Name + " eats " + food);
        return food;
    }
}
