using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Kursovay
{
    public static class NewStaff
    {
        private static ObservableCollection<Staff> staf = new ObservableCollection<Staff>();
        public static void Add(Staff staff)
        {
            try
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    dbContext.staff.Add(staff);
                    SalarySumm(staff);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении сотрудника:" + ex.Message);
            }
        }
        public static ObservableCollection<Staff> Staff()
        {
            using (var dbContext = new DatabaseRestourant())
            {
                return new ObservableCollection<Staff>(dbContext.staff.ToList());
            }
        }
        public static void Delete(int index)
        {
            if (index != -1)
                using (var dbContext = new DatabaseRestourant())
                {
                    Staff staff = dbContext.staff.ElementAtOrDefault(index);
                    if (staff != null)
                    {
                        dbContext.staff.Remove(staff);
                        dbContext.SaveChanges();
                    }
                }
        }
        public static void Change(int index, string name, string surname, string patronymic, string post)
        {
            if (index != -1)
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    Staff staff = dbContext.staff.ElementAtOrDefault(index);
                    if (staff != null)
                    {
                        staff.Name = name;
                        staff.Surname = surname;
                        staff.Patronymic = patronymic;
                        staff.Post = post;
                        dbContext.SaveChanges();
                    }
                }
            }
        }
        public static int SalarySumm(Staff staff)
        {
            staff.Salary = Kursovay.Salary.ConclusioSalary(staff.Post);
            return staff.Salary;
        }
    }
}

