using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{
    public class Furnuture : FurnitureManufacturer.Interfaces.IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;
        private string material;

        public string Model
        {
            get 
            { 
                return this.model;
            }
            set
            {
                if (value.Length >=3 && !(string.IsNullOrEmpty(value)))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentException("Model must be atleast 3 symbols and cannot be empty!");
                }
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            set
            {
                if (value.ToLower()=="wooden"|| value.ToLower() =="leather" || value.ToLower() == "plastic")
                {
                    material = value;
                }
                else
                {
                    throw new ArgumentException("The opt materials are : Wooden, Leather and Plastic");
                }
            }               
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value>0)
                {
                    price = value; 
                }
                else
                {
                    throw new ArgumentException("Price cannot be 0.00 ");
                }
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be 0.00 ");
                }
            }
        }
    }
}
