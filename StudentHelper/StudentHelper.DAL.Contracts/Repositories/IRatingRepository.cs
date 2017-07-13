using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IRatingRepository : IDisposable
    {
        IEnumerable<Rating> GetAll();

        Rating GetById(int id);

        void Add(Rating rating);

        void Remove(int id);

        void Edit(Rating rating);
    }
}