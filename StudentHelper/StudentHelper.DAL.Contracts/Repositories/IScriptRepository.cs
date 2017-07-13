using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IScriptRepository : IDisposable
    {
        IEnumerable<Script> GetAll();

        Script GetById(int id);

        void Add(Script script);

        void Remove(int id);

        void Edit(Script script);
    }
}