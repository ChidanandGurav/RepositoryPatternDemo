using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repositories;

namespace RepositoryPatternDemo.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        int IStudentService.AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        int IStudentService.DeleteStudent(int Rollno)
        {
            return repo.DeleteStudent(Rollno);
        }

        Student IStudentService.GetStudentByRollNo(int RollNo)
        {
            return repo.GetStudentByRollNo(RollNo);
        }

        IEnumerable<Student> IStudentService.GetStudents()
        {
            return repo.GetStudents();
        }

        int IStudentService.UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}
