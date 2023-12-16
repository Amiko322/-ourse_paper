using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kursovay
{
    public class Delivery
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }

        public Delivery(string name, string email, string numberPhone, string address)
        {
            Name = name;
            Email = email;
            NumberPhone = numberPhone;
            Address = address;
        }

    }
}
