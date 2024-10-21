using BLL.DAL;
using BLL.Models;
using BLL.Services.Bases;

namespace BLL.Services
{
    public interface IStudentService
    {
        public Service Create(Student student);
        public Service Update(Student student);
        public Service Delete(int id);
        public IQueryable<StudentModel> Query();
    }

    public class StudentService : Service, IStudentService
    {
        public StudentService(StudentsDBContext db) : base(db) // base: super in Java
        {

        }

        public Service Create(Student student)
        {
            if (_db.Students.Any(s => s.Id == student.Id))
                return Error("Student with the same Id exists!");
            _db.Students.Add(student);
            _db.SaveChanges();
            return Success();
        }

        public Service Delete(int id)
        {
            var student = _db.Students.Find(id);
            _db.Students.Remove(student);
            _db.SaveChanges();
            return Success();
        }


        public IQueryable<StudentModel> Query()
        {
            return _db.Students.OrderBy(c => c.Name).Select(c => new StudentModel() { Record = c });
        }

        public Service Update(Student student)
        {
            _db.Students.Update(student);
            _db.SaveChanges();
            return Success();
        }
    }
}
