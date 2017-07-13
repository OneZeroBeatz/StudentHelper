using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IRecensionRepository : IDisposable
    {
        IEnumerable<Recension> GetAll();

        Recension GetById(int id);

        void Add(Recension recension);

        void Remove(int id);

        void Edit(Recension recension);
    }
}