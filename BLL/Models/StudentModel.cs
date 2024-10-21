#nullable disable
using BLL.DAL;
using System.ComponentModel;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record { get; set; }

        public int Id => Record.Id;

        public string Name => Record.Name;

        public string Surname => Record.Surname;

        public DateTime? BirthDate => Record.BirthDate;

        public decimal? Gpa => Record.Gpa;

    }
}
