using System;
using System.Threading.Tasks;
using DAL.Interfaces.Repositories;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IQuestionRepository Question { get; }
        IResultRepository Result { get; }
        IStudentRoleRepository StudentRole { get; }
        IStudentRepository Student { get; }
        ITeacherRepository Teacher { get; }
        ITestRepository Test { get; }
        IAnswerVariantRepository AnswerVariant { get; }
        Task SaveChangesAsync();
    }
}
