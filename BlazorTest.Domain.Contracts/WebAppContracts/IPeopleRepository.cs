using BlazorTest.Domain.Entities.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Domain.Contracts.WebAppContracts
{
    public interface IPeopleRepository
    {
        Person FindById(int id);
        IQueryable<Person> GetAll();
        void DeleteById(int id);
        void Add(Person person);
        void Update(int id, Person person);
    }
}
