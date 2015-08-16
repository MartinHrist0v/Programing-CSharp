using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FurnitureManufacturer
{

    public class Company : FurnitureManufacturer.Interfaces.ICompany
    {
        private string name;
        private List<Interfaces.IFurniture> furnitures = new List<Interfaces.IFurniture>();
        private string registrationNumber;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!(string.IsNullOrEmpty(value)) && value.Length > 5)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("The name must be atleast 5 symbols!");
                }
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                if (value.Length == 10 && IsDigitsOnly(value))
                {
                    registrationNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid registration number");
                }
            }
        }

        public ICollection<Interfaces.IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(Interfaces.IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(Interfaces.IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public Interfaces.IFurniture Find(string model) // TODO : CHECK IT 
        {
            return this.furnitures.FirstOrDefault(i => i.Model.ToLower() == model.ToLower());
        }
        public string Catalog()
        {
            StringBuilder sb = new StringBuilder();
            string companyInfo= string.Format("{0} - {1} - {2} {3}",
            this.Name, this.RegistrationNumber, this.Furnitures.Count != 0 ?
            this.Furnitures.Count.ToString() : "no",
            this.Furnitures.Count != 1 ? "furnitures" : "furniture");
            sb.Append(companyInfo);
            furnitures.OrderBy(i=>i.Price).ThenBy(i=>i.Model);
            foreach (var item in furnitures)
            {

                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        private bool IsDigitsOnly(string str) //
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}



