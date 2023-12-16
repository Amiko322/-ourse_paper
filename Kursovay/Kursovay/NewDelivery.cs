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
    public static class NewDelivery
    {
        private static ObservableCollection<Delivery> deliv = new ObservableCollection<Delivery>();
        public static void Add(Delivery delivery)
        {
            try
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    dbContext.delivery.Add(delivery);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении поставщика:" + ex.Message);
            }
        }
        public static ObservableCollection<Delivery> Delivery()
        {
            using (var dbContext = new DatabaseRestourant())
            {
                return new ObservableCollection<Delivery>(dbContext.delivery.ToList());
            }
        }
        public static void Delete(int index)
        {
            if (index != -1)
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    Delivery delivery = dbContext.delivery.ElementAtOrDefault(index);
                    if (delivery != null)
                    {
                        dbContext.delivery.Remove(delivery);
                        dbContext.SaveChanges();
                    }
                }
            }
        }
        public static void Change(int index, string name, string email, string numberPhone, string address)
        {
            if (index != -1)
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    Delivery delivery = dbContext.delivery.ElementAtOrDefault(index);
                    if (delivery != null)
                    {

                        delivery.Name = name;
                        delivery.Email = email;
                        delivery.NumberPhone = numberPhone;
                        delivery.Address = address;

                        dbContext.SaveChanges();
                    }
                }
            }
        }
    }
}