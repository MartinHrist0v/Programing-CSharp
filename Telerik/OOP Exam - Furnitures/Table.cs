using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class Table : Furnuture, FurnitureManufacturer.Interfaces.ITable
    {
        private decimal lenght;
        private decimal width;
        public decimal Length
        {
            get
            {
                return this.lenght;
            }
            set
            {
                if (value>0)
                {
                    this.lenght = value;
                }
                else
                {
                    throw new ArgumentException("Lenght can not be equal or less than 0");
                }
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width can not be equal or less than 0");
                }
            }
        }

        public decimal Area
        {
            get { return this.lenght * this.width; }
        }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);
        }
    }
}
