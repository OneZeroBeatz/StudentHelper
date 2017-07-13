using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface ILanguageRepository : IDisposable
    {
        IEnumerable<Language> GetAll();

        Language GetById(int id);

        void Add(Language language);

        void Remove(int id);

        void Edit(Language language);
    }
}