﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using DAL.Interfaces;
using BLL.Interfaces;
using DAL.Domain.Entities;
using System.Threading.Tasks;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BLL.Infrastructure.Services
{
    public class TeacherService : BaseService, ITeacherService
    {
        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        //public async Task<TeacherDTO> GetTeacherByStudentIdAsync(int id)
        //{
        //    var student = await UnitOfWork.Student.GetByIdAsync(id);
        //    var teacher = await UnitOfWork.Teacher.GetByIdAsync(student.TeacherId);
        //    return Mapper.Map<Teacher, TeacherDTO>(teacher);
        //}

        public async Task<int> GetTeacherIdByUserIdAsync(string userId)
        {
            var allTeachers = await UnitOfWork.Teacher.GetAllAsync();
            var result = allTeachers.Where(x => x.UserId == userId).FirstOrDefault();
            var resultDTO = Mapper.Map<Teacher, TeacherDTO>(result);
            return resultDTO.Id;
        }


        public async Task<TeacherDTO> GetTeacherByIdAsync(int id)
        {
            var result = await UnitOfWork.Teacher.GetByIdAsync(id);
            var resultDTO = this.Mapper.Map<Teacher, TeacherDTO>(result);
            return resultDTO;
        }

        public async Task AddTeacher(TeacherDTO teacher)
        {
            var teacherMapped = Mapper.Map<TeacherDTO, Teacher>(teacher);
            await UnitOfWork.Teacher.CreateAsync(teacherMapped);
        }

    }
}
