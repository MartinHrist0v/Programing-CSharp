using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class Chair : Furnuture, FurnitureManufacturer.Interfaces.IChair
    {
        public int NumberOfLegs { get;  set; }
        public override string ToString()
        {
            return string.Format(" Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
        }
		
		
		
    }
}
