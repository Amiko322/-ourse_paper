using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations;

namespace Kursovay
{
    public class Staff
    {
        [Key]
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Post {  get; set; }
        public int Salary { get; set; }

        public Staff(string name, string surname, string patronymic, string post) 
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Post = post;
        }
        public Staff(string name, string surname, string patronymic, string post, int salary) 
        { 
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Post = post;
            Salary = salary;
        }
    }
}
