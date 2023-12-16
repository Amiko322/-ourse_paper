using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace Kursovay
{
    public static class AuthorizationUserRoles
    {
        public static void IDSearch(string login, int password)
        {
            using (var dbContext = new DatabaseUser())
            {
                var user = dbContext.log.Include(u => u.Role).FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    Roles(user.Role.Id);
                }
            }
        }

        public static void Roles(int RolesID)  
        {
            switch (RolesID)
            {
                case 1:
                    OpenDirector(); 
                    break;
                case 2:
                    OpenStaffDepartament();
                    break;
                default:
                    break;
            }
        }

        public static void OpenDirector()  
        { 
            Director director = new Director();
            director.Show();
            Application.Current.MainWindow.Close();
        }

        public static void OpenStaffDepartament()
        {
            StaffDepartament staffDepartament = new StaffDepartament();
            staffDepartament.Show();
            Application.Current.MainWindow.Close();
        }
    }
}
