namespace FurnitureManufacturer.Engine.Factories
{
    using System;

    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            // TODO: Implement this method
            return new Table() { Model = model, Material = materialType, Price= price, Height = height, Length = length, Width =width};
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // TODO: Implement this method
            return new Chair() { Model = model, Material = materialType, Price = price, Height = height, NumberOfLegs = numberOfLegs };
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // TODO: Implement this method
            return new AdjustableChair() { Model = model, Material = materialType, Price = price, Height = height, NumberOfLegs = numberOfLegs };
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            // TODO: Implement this method
            return new ConvertableChair() { Model = model, Material = materialType, Price = price, Height = height, NumberOfLegs = numberOfLegs };
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
