using System;
using System.Linq;
using System.Collections.Generic;

namespace Entity_Framework_LINQ;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> listOfAnimals = new List<Animal>();
        List<Species> whiteCougarSpecies = new List<Species>();
        List<Species> whiteTigerSpecies = new List<Species>();
        List<Species> albinoTurtleSpecies = new List<Species>();


        for (int i = 0; i <= 2; i++)
        {
            Species whiteCougarIndividual = new Species("White cougar");
            whiteCougarIndividual.Name = "White cougar";
            whiteCougarSpecies.Add(whiteCougarIndividual);
            listOfAnimals.Add(whiteCougarIndividual);
        }

        for (int i = 0; i <= 99; i++)
        {
            Species whiteTigerIndividual = new Species("White tiger");
            whiteTigerIndividual.Name = "White tiger";
            whiteTigerSpecies.Add(whiteTigerIndividual);
            listOfAnimals.Add(whiteTigerIndividual);
        }

        for (int i = 0; i <= 14; i++)
        {
            Species albinoTurtleIndividual = new Species("Albino turtle");
            albinoTurtleIndividual.Name = "Albino turtle";
            albinoTurtleSpecies.Add(albinoTurtleIndividual);
            listOfAnimals.Add(albinoTurtleIndividual);
        }

        var whiteCougarCount = (from spec in whiteCougarSpecies
                                 where spec.Name == "White cougar"
                                 select spec).Count();
        Console.WriteLine($"White cougar: {whiteCougarCount}");

        var whiteTigerCount = (from spec in whiteTigerSpecies
                                where spec.Name == "White tiger"
                                select spec).Count();
        Console.WriteLine($"White tiger: {whiteTigerCount}");

        var albinoTurtleCount = (from spec in albinoTurtleSpecies
                               where spec.Name == "Albino turtle"
                                 select spec).Count();
        Console.WriteLine($"Albino turtle: {albinoTurtleCount}");

    }
}

