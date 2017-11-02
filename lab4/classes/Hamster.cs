using System;
using System.Text;

public class Hamster : IAnimal
{
    public string Name { get; set; }

    public void MakeNoise()
    {
        string noise = "chit chit";
        Console.WriteLine(Name + " says " + noise);
    }
    public string Eat()
    {
        string food = "carrots";
        Console.WriteLine(Name + " eats " + food);
        return food;
    }
}