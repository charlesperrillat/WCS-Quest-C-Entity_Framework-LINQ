using System;
namespace Entity_Framework_LINQ
{
	public abstract class Animal
	{

        public Guid AnimalId { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Species Species { get; set; }

        public Animal(string name)
		{
		}
	}
}

