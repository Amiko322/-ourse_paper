using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Kursovay
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            DatabaseFacade facade = new DatabaseFacade(new DatabaseRestourant());
            facade.EnsureCreated();

            DatabaseFacade facade2 = new DatabaseFacade(new DatabaseUser());
            facade2.EnsureCreated();

        }
    }

}
