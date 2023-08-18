//polymorphism 

using System.Globalization;
using System.Transactions;

class Being
{
    public virtual void introduction()
    {
        Console.WriteLine("I am a being");
    }

}

class Human : Being
{
    public string name;
    public int age;
    public string skinColour;
    public double weight;
    public string countryOfOrigin;

    public Human(string name, int age, string skinColour, double weight, string countryOfOrigin)
    {
        this.name = name;
        this.age = age;
        this.skinColour = skinColour;
        this.weight = weight;
        this.countryOfOrigin = countryOfOrigin;
    }

    public override void introduction()
    {
        Console.WriteLine("My name is "+name+ " I am "+age +" years old. I am "+ skinColour + " I weigh "+weight + " I come from "+countryOfOrigin);
        Console.WriteLine("I am a human");
    }
}

class Alien : Being
{ 

    public string name;
    public int age;
    public string skinColour;
    public double weight;
    public string planet;

    public Alien(string name, int age, string skinColour, double weight, string planet)
    {
        this.name = name;
        this.age = age;
        this.skinColour = skinColour;
        this.weight = weight;
        this.planet = planet;
    }

    public override void introduction()
    {
        Console.WriteLine("My name is " + name + " I am " + age + " years old. I am " + skinColour + " I weigh " + weight + " I come from planet " + planet);
        Console.WriteLine("I am an alien from space");
    }
}

class Program
{
    static void Main(string[] args )
    {
        Human human = new Human("Josh",18,"brown",55.5d,"Poland");
        human.introduction();
        Alien alien = new Alien("Zigz", 889, "green", 6.6d, "Mars");
        alien.introduction();
        Being being = new Being();
        being.introduction();
    }

}
