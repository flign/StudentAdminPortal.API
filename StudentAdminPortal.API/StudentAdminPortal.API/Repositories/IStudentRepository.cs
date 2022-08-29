using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gender = StudentAdminPortal.API.DataModels.Gender;
using Student = StudentAdminPortal.API.DataModels.Student;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentAsync(Guid studentId);
        Task<List<Gender>>GetGendersAsync();

        Task<bool> Exists(Guid studentId);
        Task<Student> UpdateStudent(Guid studentId, Student request);

        Task<Student> DeleteStudent(Guid studentId);

        Task<Student> AddStudent(Student request);
    }
}
