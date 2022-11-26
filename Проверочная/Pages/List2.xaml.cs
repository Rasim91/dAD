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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Проверочная.Components;

namespace Проверочная.Pages
{
    /// <summary>
    /// Логика взаимодействия для List2.xaml
    /// </summary>
    public partial class List2 : Page
    {
        public List2()
        {
            InitializeComponent();
            EmployeeList.ItemsSource = DBConnect.Entities.Employee.ToList();
        }
    }
}
