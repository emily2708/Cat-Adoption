using System;
namespace Cat_Adoption.Models
{
	public class Cat
	{
        public int id { get; set; }
        
        public required string Name { get; set; }
        public required string Breed { get; set; }
        public int age { get; set; }
        public double price { get; set; }
        public bool isAdopted { get; set; }
        public required string center { get; set; }

        public string url { get; set; }
    }
}

