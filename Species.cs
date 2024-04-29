using System;
namespace Entity_Framework_LINQ
{
	public class Species : Animal
	{
        public int SpeciesId { get; set; }
        public String Name { get; set; }

        public Species(string name) : base(name)
		{
		}
	}
}

