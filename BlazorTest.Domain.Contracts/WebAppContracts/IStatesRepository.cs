using BlazorTest.Domain.Entities.Location;
using BlazorTest.Domain.Entities.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorTest.Domain.Contracts.WebAppContracts
{
    public interface IStatesRepository
    {
        State FindById(int id);
        IQueryable<State> GetAll();
        void DeleteById(int id);
        void Add(State state);
        void Update(int id, State state);
    }
}
