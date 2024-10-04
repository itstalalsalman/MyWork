#nullable disable
using BLL.DAL;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Student { get; set; }

        public int Id => Student.Id;

        public string Name => Student.Name;

        public string Surname => Student.Surname;

        public DateTime? BirthDate => Student.BirthDate;

        public decimal? Gpa => Student.Gpa;



    }
}
