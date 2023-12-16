using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StaffDepartament : Window
    {
        public List<Staff> Staff { get; set; }

        public StaffDepartament()
        {
            InitializeComponent();

            using (DatabaseRestourant _context = new DatabaseRestourant())
            {
                DataGridStaff.ItemsSource = _context.staff.ToList();
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

    }
}