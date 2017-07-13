using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetAll();

        User GetById(int id);

        void Add(User user);

        void Remove(int id);

        void Edit(User user);
    }
}