using BlazorTest.Domain.Contracts.WebAppContracts;
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
    public class PeopleRepository : IPeopleRepository
    {
        private readonly BlazorTestDbContext _blazorTestDbContext;

        public PeopleRepository(BlazorTestDbContext blazorTestDbContext)
        {
            this._blazorTestDbContext = blazorTestDbContext;
        }

        public void Add(Person person)
        {
            this._blazorTestDbContext.People.Add(person);
            this._blazorTestDbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            this._blazorTestDbContext.People.Remove(FindById(id));
            this._blazorTestDbContext.SaveChanges();
        }

        public Person FindById(int id)
        {
            return this._blazorTestDbContext.People.Include(x => x.City).Include(x => x.City.State).Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<Person> GetAll()
        {
            return this._blazorTestDbContext.People.Include(x => x.City).Include(x => x.City.State);
        }

        public void Update(int id, Person person)
        {
            var model = FindById(person.Id);
            model.FirstName = person.FirstName;
            model.LastName = person.LastName;
            model.City = person.City;
            model.Address = person.Address;
            model.Email = person.Email;
            this._blazorTestDbContext.People.Update(model);
            this._blazorTestDbContext.SaveChanges();
        }
    }
}


