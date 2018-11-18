using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Services
{
    public interface IRestautantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
