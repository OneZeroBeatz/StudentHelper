using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IUserUseScriptRepository : IDisposable
    {
        IEnumerable<UserUseScript> GetAll();

        UserUseScript GetById(int id);

        void Add(UserUseScript userUseScript);

        void Remove(int id);

        void Edit(UserUseScript userUseScript);
    }
}