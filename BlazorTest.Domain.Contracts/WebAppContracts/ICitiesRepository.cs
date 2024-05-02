using BlazorTest.Domain.Entities.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Domain.Contracts.WebAppContracts
{
    public interface ICitiesRepository
    {
        City FindById(int id);
        IQueryable<City> FindFyStateId(int id);
        IQueryable<City> GetAll();
        void DeleteById(int id);
        void Add(City city);
        void Update(int id, City city);
    }
}
