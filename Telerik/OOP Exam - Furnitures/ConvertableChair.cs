using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class ConvertableChair : Chair, FurnitureManufacturer.Interfaces.IConvertibleChair
    {
        private bool converted = false;
        private decimal initialSize;
        public bool IsConverted
        {
            get { return this.converted; }
        }

        public void Convert() //TODO: maybe
        {
            initialSize = Height;
            if (converted)
            {
                Height = initialSize;
                this.converted = false; // converted to normal
            }
            else
            {
                this.converted = true;  // normal to  converted
                Height = 0.1m;
            }
        }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
