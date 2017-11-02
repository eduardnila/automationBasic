using System;

public class Dog : IAnimal
{
    public string Name { get; set; }
    public void MakeNoise()
    {
        string noise = "ham ham";
        Console.WriteLine(Name + " says " + noise);
    }
    public string Eat()
    {
        string food = "bones";
        Console.WriteLine(Name + " eats " + food);
        return food;
    }
}
