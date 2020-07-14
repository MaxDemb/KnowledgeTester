using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.EntityFramework.Repositories;
using DAL.Interfaces;
using DAL.Interfaces.Repositories;
using DAL.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using DAL.Domain.Entities;


// Видалити після видалення пустого конструктора 


namespace DAL.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        public IQuestionRepository Question { get; }
        public IResultRepository Result { get; }
        public IStudentRepository Student { get; }
        public ITeacherRepository Teacher { get; }
        public ITestRepository Test { get; }
         
        public IStudentRoleRepository StudentRole { get; set; }
        public IAnswerVariantRepository AnswerVariant { get; }

        private readonly DbContext _context;

        //public UnitOfWork(DbContext context,
        //    IQuestionRepository Question,
        //    IResultRepository Result,
        //    IStudentRepository Student,
        //    ITeacherRepository Teacher,
        //    ITestRepository Test)
        //{
        //    this._context = context;
        //    this.Question = Question;
        //    this.Result = Result;
        //    this.Student = Student;
        //    this.Teacher = Teacher;
        //    this.Test = Test;
        //}

        public UnitOfWork(DbContext context)
        {
            this._context = context;
            this.Question = new QuestionRepository(this._context);
            this.Result = new ResultRepository(this._context);
            this.Student = new StudentRepository(this._context);
            this.Teacher = new TeacherRepository(this._context);
            this.Test = new TestRepository(this._context);
            this.AnswerVariant = new AnswerVariantRepository(this._context);
            this.StudentRole = new StudentRoleRepository(this._context);

        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
