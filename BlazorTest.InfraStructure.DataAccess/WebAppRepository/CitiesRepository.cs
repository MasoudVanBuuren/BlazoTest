using BlazorTest.Domain.Contracts.WebAppContracts;
using BlazorTest.Domain.Entities.Location;
using BlazorTest.Domain.Entities.People;
using BlazorTest.InfraStructure.DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.InfraStructure.DataAccess.WebAppRepository
{
    public class CitiesRepository : ICitiesRepository
    {
        private readonly BlazorTestDbContext _blazorTestDbContext;

        public CitiesRepository(BlazorTestDbContext blazorTestDbContext)
        {
            this._blazorTestDbContext = blazorTestDbContext;
        }
        public void Add(City city)
        {
            this._blazorTestDbContext.Cities.Add(city);
            this._blazorTestDbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            this._blazorTestDbContext.Cities.Remove(FindById(id));
            this._blazorTestDbContext.SaveChanges();
        }

        public City FindById(int id)
        {
            return this._blazorTestDbContext.Cities.Include(x => x.State).Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<City> FindFyStateId(int id)
        {
            return this._blazorTestDbContext.Cities.Include(x=>x.State).Where(x=>x.StateId == id);
        }

        public IQueryable<City> GetAll()
        {
            return this._blazorTestDbContext.Cities;
        }

        public void Update(int id, City city)
        {
            var model = FindById(city.Id);
            model.Name = city.Name;
            this._blazorTestDbContext.Cities.Update(city);
            this._blazorTestDbContext.SaveChanges();
        }
    }
}
