using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kursovay
{
    /// <summary>
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Window
    {
        public List<Staff> Staff { get; set; }
        public List<Restourant> Restourant { get; set; }
        public List<Delivery> Delivery { get; set; }
        public List<Products> Products { get; set; }

        public Director()
        {
            InitializeComponent();
            using (DatabaseRestourant _context = new DatabaseRestourant())
            {
                DataGridStaff.ItemsSource = _context.staff.ToList();
            }
            using (DatabaseRestourant _context = new DatabaseRestourant())
            {
                DataGridRestourant.ItemsSource = _context.restourant.ToList();
            }
            using (DatabaseRestourant _context = new DatabaseRestourant())
            {
                DataGridDelivery.ItemsSource = _context.delivery.ToList();
            }
            using (DatabaseRestourant _context = new DatabaseRestourant())
            {
                DataGridProducts.ItemsSource = _context.products.ToList();
            }
        }

        private void RestourantAdd_Button(object sender, RoutedEventArgs e) // ресторан добавление
        {
            if (RestourantEmail.Text != "" && RestourantAddress.Text != "" && RestourantNumberPhone.Text != "")
            {
                Restourant restourant = new Restourant(RestourantEmail.Text, RestourantNumberPhone.Text, RestourantAddress.Text);
                NewRestourant.Add(restourant);
                DataGridRestourant.ItemsSource = NewRestourant.Restourant();
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }
        }

        private void RestourantDelete_Button(object sender, RoutedEventArgs e)// ресторан удаление
        {
            NewRestourant.Delete(DataGridRestourant.SelectedIndex);
            DataGridRestourant.ItemsSource = NewRestourant.Restourant(); // Обновление списка в DataGrid
            DataGridRestourant.Items.Refresh();// Обновление представления
        }

        private void RestourantChange_Button(object sender, RoutedEventArgs e)// ресторан изменение
        {
            if (RestourantEmail.Text != "" && RestourantAddress.Text != "" && RestourantNumberPhone.Text != "")
            {
                NewRestourant.Change(DataGridRestourant.SelectedIndex, RestourantEmail.Text, RestourantNumberPhone.Text, RestourantAddress.Text);
                DataGridRestourant.ItemsSource = NewRestourant.Restourant(); // Обновление списка в DataGrid
                DataGridRestourant.Items.Refresh(); // Обновление представления
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }


        }

        private void StaffAdd_Button(object sender, RoutedEventArgs e)// сотрудники добавление
        {
            if (Surname.Text != "" && StaffName.Text != "" && Patronymic.Text != "")
            {
                Staff staff = new Staff(StaffName.Text, Surname.Text, Patronymic.Text, Post.Text);
                NewStaff.Add(staff);
                DataGridStaff.ItemsSource = NewStaff.Staff();
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }
        }

        private void StaffChange_Button(object sender, RoutedEventArgs e) // сотрудники изменение
        {
            if (Surname.Text != "" && StaffName.Text != "" && Patronymic.Text != "")
            {
                NewStaff.Change(DataGridStaff.SelectedIndex, Surname.Text, StaffName.Text, Patronymic.Text, Post.Text);
                DataGridStaff.ItemsSource = NewStaff.Staff(); // Обновление списка в DataGrid
                DataGridStaff.Items.Refresh();// Обновление представления
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }
        }

        private void StaffDelete_Button(object sender, RoutedEventArgs e) // сотрудники удаление
        {

            NewStaff.Delete(DataGridStaff.SelectedIndex);
            DataGridStaff.ItemsSource = NewStaff.Staff(); // Обновление списка в DataGrid
            DataGridStaff.Items.Refresh();// Обновление представления
        }

        private void ProductAdd_Button(object sender, RoutedEventArgs e) // продукты добавление
        {
            try
            {
                if (ProductName.Text != "" && Weight.Text != "" && ProductPrice.Text != "")
                {
                    Products products = new Products(ProductName.Text, Convert.ToDouble(Weight.Text), Convert.ToInt32(ProductPrice.Text));
                    NewProducts.Add(products);
                    DataGridProducts.ItemsSource = NewProducts.Products();
                }
                else
                {
                    MessageBox.Show("Заполните все поля! ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ProductsChange_Button(object sender, RoutedEventArgs e) // продукты изменение
        {
            if (ProductName.Text != "" && Weight.Text != "" && ProductPrice.Text != "")
            {
                NewProducts.Change(DataGridProducts.SelectedIndex, ProductName.Text, Convert.ToDouble(Weight.Text), Convert.ToInt32(ProductPrice.Text));
                DataGridProducts.ItemsSource = NewProducts.Products(); // Обновление списка в DataGrid
                DataGridProducts.Items.Refresh();// Обновление представления
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }
        }

        private void ProductsDelete_Button(object sender, RoutedEventArgs e) // продукты удаление
        {
            NewProducts.Delete(DataGridProducts.SelectedIndex);
            DataGridProducts.ItemsSource = NewProducts.Products(); // Обновление списка в DataGrid
            DataGridProducts.Items.Refresh();// Обновление представления
        }

        private void DeliveryAdd_Button(object sender, RoutedEventArgs e) // поставщики добавление 
        {
            if (DeliveryName.Text != "" && DeliveryEmail.Text != "" && DeliveryNumberPhone.Text != "" && DeliveryAddress.Text != "")
            {
                Delivery deliv = new Delivery(DeliveryName.Text, DeliveryEmail.Text, DeliveryNumberPhone.Text, DeliveryAddress.Text);
                NewDelivery.Add(deliv);
                DataGridDelivery.ItemsSource = NewDelivery.Delivery();
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }
        }

        private void DeliveryChange_Button(object sender, RoutedEventArgs e) //  поставщики изменение
        {
            if (DeliveryName.Text != "" && DeliveryEmail.Text != "" && DeliveryNumberPhone.Text != "" && DeliveryAddress.Text != "")
            {
                NewDelivery.Change(DataGridDelivery.SelectedIndex, DeliveryName.Text, DeliveryEmail.Text, DeliveryNumberPhone.Text, DeliveryAddress.Text);
                DataGridDelivery.ItemsSource = NewDelivery.Delivery(); // Обновление списка в DataGrid
                DataGridDelivery.Items.Refresh();// Обновление представления
            }
            else
            {
                MessageBox.Show("Заполните все поля! ");
            }
        }

        private void DeliveryDelete_Button(object sender, RoutedEventArgs e) // поставщики удаление
        {
            NewDelivery.Delete(DataGridDelivery.SelectedIndex);
            DataGridDelivery.ItemsSource = NewDelivery.Delivery(); // Обновление списка в DataGrid
            DataGridDelivery.Items.Refresh();// Обновление представления
        }

        private void Validation_BlockText(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9+]+").IsMatch(e.Text);
        }

        private void Validation_BlockNumbers(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsLetter(c))
                {
                    e.Handled = true;
                    return;
                }
            }
        }
        private void Validation_BlockLetters(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Проверяем, что вводимый текст - это число (цифры) или запятая
            if (!(new Regex("[0-9]+").IsMatch(e.Text) || (e.Text == "," && !textBox.Text.Contains(","))))
            {
                e.Handled = true; // Предотвращаем ввод, если условие не выполнено
            }

        }
    }
}

