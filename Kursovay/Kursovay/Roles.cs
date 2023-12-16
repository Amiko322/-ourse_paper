using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovay
{
    public class Roles
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }


        public Roles(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
