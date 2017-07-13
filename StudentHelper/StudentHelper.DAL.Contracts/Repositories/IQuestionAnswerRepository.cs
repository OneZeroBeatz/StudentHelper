using StudentHelper.DAL.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace StudentHelper.DAL.Contracts.Repositories
{
    public interface IQuestionAnswerRepository : IDisposable
    {
        IEnumerable<QuestionAnswer> GetAll();

        QuestionAnswer GetById(int id);

        void Add(QuestionAnswer questionAnswer);

        void Remove(int id);

        void Edit(QuestionAnswer questionAnswer);
    }
}