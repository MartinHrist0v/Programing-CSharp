namespace FurnitureManufacturer.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;

    public class CompanyFactory : ICompanyFactory
    {
        public ICompany CreateCompany(string name, string registrationNumber)
        {
            // TODO: Implement this methozd            
            return new Company() { Name = name, RegistrationNumber = registrationNumber};
            
        }
    }
}
