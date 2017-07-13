using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IScienceRepository : IDisposable
    {
        IEnumerable<Science> GetAll();

        Science GetById(int id);

        void Add(Science science);

        void Remove(int id);

        void Edit(Science science);
    }
}