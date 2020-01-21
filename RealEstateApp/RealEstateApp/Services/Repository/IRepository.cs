using RealEstateApp.Models;
using System.Collections.Generic;

namespace RealEstateApp.Services
{
    public interface IRepository
    {
        List<Agent> GetAgents();
        List<Property> GetProperties();
        void SaveProperty(Property property);
    }
}
