using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IStudentService 
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByRollNo(int RollNo);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int Rollno);
    }
}
