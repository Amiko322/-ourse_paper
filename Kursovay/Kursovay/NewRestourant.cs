using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.EntityFrameworkCore;

namespace Kursovay
{
    public static class NewRestourant
    {
        private static ObservableCollection<Restourant> rest = new ObservableCollection<Restourant>();
        public static void Add(Restourant restourant)
        {
            try
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    dbContext.restourant.Add(restourant);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении ресторана:" + ex.Message);
            }
        }
        public static ObservableCollection<Restourant> Restourant()
        {
            using (var dbContext = new DatabaseRestourant())
            {
                return new ObservableCollection<Restourant>(dbContext.restourant.ToList());
            }
        }
        public static void Delete(int index)
        {
            if (index != -1)
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    Restourant restourant = dbContext.restourant.ElementAtOrDefault(index);
                    if (restourant != null)
                    {
                        dbContext.restourant.Remove(restourant);
                        dbContext.SaveChanges();
                    }
                }
            }
        }
        public static void Change(int index, string email, string numberPhone, string address)
        {
            if (index != -1)
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    Restourant restourant = dbContext.restourant.ElementAtOrDefault(index);
                    if (restourant != null)
                    {
                        restourant.Address = address;
                        restourant.NumberPhone = numberPhone;
                        restourant.Email = email;
                        dbContext.SaveChanges();
                    }
                }
            }
        }
    }

}
