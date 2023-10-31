using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }
        int IStudentRepository.AddStudent(Student student)
        {
            db.Students.Add(student);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        int IStudentRepository.DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.RollNo == id).FirstOrDefault();
            if (result != null)
            {
                db.Students.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        Student IStudentRepository.GetStudentByRollNo(int id)
        {
            var result = db.Students.Where(x => x.RollNo == id).SingleOrDefault();
            return result;
        }

        IEnumerable<Student> IStudentRepository.GetStudents()
        {
            return db.Students.ToList();
        }

        int IStudentRepository.UpdateStudent(Student student)
        {
            int res = 0;


            var result = db.Students.Where(x => x.RollNo == student.RollNo).FirstOrDefault();

            if (result != null)
            {
                result.Name = student.Name; // book contains new data, result contains old data
                result.City = student.City;
                result.Percentage = student.Percentage;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
