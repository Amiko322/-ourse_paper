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
    public static class NewProducts
    {
        private static ObservableCollection<Products> prod = new ObservableCollection<Products>();
        public static void Add(Products products)
        {
            try
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    dbContext.products.Add(products);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при добавлении продукта:" + ex.Message);
            }
        }
        public static ObservableCollection<Products> Products()
        {
            using (var dbContext = new DatabaseRestourant())
            {
                return new ObservableCollection<Products>(dbContext.products.ToList());
            }
        }
        public static void Delete(int index)
        {
            if (index != -1)
                using (var dbContext = new DatabaseRestourant())
                {
                    Products products = dbContext.products.ElementAtOrDefault(index);
                    if (products != null)
                    {
                        dbContext.products.Remove(products);
                        dbContext.SaveChanges();
                    }
                }
        }
        public static void Change(int index, string name, double weight, int price)
        {
            if (index != -1)
            {
                using (var dbContext = new DatabaseRestourant())
                {
                    Products products = dbContext.products.ElementAtOrDefault(index);
                    if (products != null)
                    {
                        products.Name = name;
                        products.Weight = weight;
                        products.Price = price;
                        dbContext.SaveChanges();
                    }
                }
            }
        }
    }
}

