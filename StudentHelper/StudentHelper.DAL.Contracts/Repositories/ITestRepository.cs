using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface ITestRepository : IDisposable
    {
        IEnumerable<Test> GetAll();

        Test GetById(int id);

        void Add(Test test);

        void Remove(int id);

        void Edit(Test test);
    }
}