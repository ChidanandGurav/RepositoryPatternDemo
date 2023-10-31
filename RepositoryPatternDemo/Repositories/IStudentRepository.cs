using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByRollNo(int RollNo);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int Rollno);
    }
}
