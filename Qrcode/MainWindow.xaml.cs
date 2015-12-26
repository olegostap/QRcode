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

namespace Qrcode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 secondForm;
        public MainWindow()
        {
            InitializeComponent();
        }
        string logadmin="admin";
        string passadmin = "admin";
        string logauser = "user1";
        string passuser = "user";
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if(logadmin == login.Text && passadmin == passwordbox.Password)
            {
                Window1 secondForm = new Window1();
                secondForm.Show();
            }
            if (logauser == login.Text && passuser == passwordbox.Password)
            {
                Window2 secondForm = new Window2();
                secondForm.Show();
            }
            this.Close();
        }
    }
}
