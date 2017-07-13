using StudentHelper.DAL.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.DAL.Contracts
{
    public interface IUnitOfWork
    {
        ILanguageRepository Languages { get; }
        IQuestionAnswerRepository QuestionAnswers { get; }
        IRatingRepository Ratings { get; }
        IRecensionRepository Recensions { get; }
        IScienceRepository Sciences { get; }
        IScriptRepository Scripts { get; }
        ITestRepository Tests { get; }
        IUserRepository Users { get; }
        IUserUseScriptRepository UserUseScripts { get; }
    }
}
