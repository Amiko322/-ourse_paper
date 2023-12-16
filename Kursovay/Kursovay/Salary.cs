using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovay
{
    public static class Salary
    {
        public static int Employee { get; } = 45130;
        public static int Instructor { get; } = 55870;
        public static int Manager { get; } = 75340;
        public static int Asistent { get; } = 98400;

        public static int ConclusioSalary(string post)
        {
            switch(post) 
            {
                case "Работник":
                     return Employee;
                case "Инструктор":
                    return Instructor;
                case "Менеджер":
                    return Manager;
                case "Ассистент":
                    return Asistent;
                default:
                    return 0;
            } 
        }
    }
}
