using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IReproducible
{
    void Reproduce();
}

// Інтерфейс для полювання
interface IPredator
{
    void Hunt();
}

// Базовий клас Живий організм
class LivingOrganism
{
    public int Energy { get; set; }
    public int Age { get; set; }
    public int Size { get; set; }

    public LivingOrganism(int energy, int age, int size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}

// Клас Тварина
class Animal : LivingOrganism, IReproducible, IPredator
{
    public Animal(int energy, int age, int size) : base(energy, age, size)
    {
    }

    public void Reproduce()
    {
        Console.WriteLine("Animal is reproducing.");
    }

    public void Hunt()
    {
        Console.WriteLine("Animal is hunting.");
    }
}

// Клас Рослина
class Plant : LivingOrganism, IReproducible
{
    public Plant(int energy, int age, int size) : base(energy, age, size)
    {
    }

    public void Reproduce()
    {
        Console.WriteLine("Plant is reproducing.");
    }
}

// Клас Мікроорганізм
class Microorganism : LivingOrganism, IReproducible
{
    public Microorganism(int energy, int age, int size) : base(energy, age, size)
    {
    }

    public void Reproduce()
    {
        Console.WriteLine("Microorganism is reproducing.");
    }
}

// Клас Екосистема
class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateInteractions()
    {
        foreach (var organism in organisms)
        {
            if (organism is IReproducible reproducible)
            {
                reproducible.Reproduce();
            }

            if (organism is IPredator predator)
            {
                predator.Hunt();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal lion = new Animal(100, 5, 10);
        Plant tree = new Plant(50, 10, 5);
        Microorganism bacteria = new Microorganism(20, 1, 1);

        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(tree);
        ecosystem.AddOrganism(bacteria);

        ecosystem.SimulateInteractions();
        Console.ReadKey();
    }
}