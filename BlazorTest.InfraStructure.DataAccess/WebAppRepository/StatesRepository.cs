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
    public class StatesRepository : IStatesRepository
    {
        private readonly BlazorTestDbContext _blazorTestDbContext;

        public StatesRepository(BlazorTestDbContext blazorTestDbContext)
        {
            this._blazorTestDbContext = blazorTestDbContext;
        }

        public void Add(State state)
        {
            this._blazorTestDbContext.States.Add(state);
            this._blazorTestDbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            this._blazorTestDbContext.States.Remove(FindById(id));
            this._blazorTestDbContext.SaveChanges();
        }

        public State FindById(int id)
        {
            return this._blazorTestDbContext.States.Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<State> GetAll()
        {
            return this._blazorTestDbContext.States;
        }

        public void Update(int id, State state)
        {
            var model = FindById(state.Id);
            model.Name = state.Name;
            this._blazorTestDbContext.States.Update(state);
            this._blazorTestDbContext.SaveChanges();
        }
    }
}
