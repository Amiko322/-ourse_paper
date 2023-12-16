using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Entrance_Button(object sender, RoutedEventArgs e)
        {
            try
            {
                AuthorizationUserRoles.IDSearch(Logins.Text, Convert.ToInt32(Password.Text));
            }
            catch
            {
                MessageBox.Show("Ошибка ввода логина или пароля");
            }
        }
    }
}
