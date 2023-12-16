using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovay
{
    public class Log
    {
        [Key]
        public int Id {  get; set; }
        public string Login { get; set; }
        public int Password { get; set; }

        [ForeignKey("Roles")]
        public Roles Role { get; set; }

        public Log(int id, string login, int password) 
        {
            Id = id;
            Login = login;
            Password = password;
        }
    }
}
