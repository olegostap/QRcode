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
        public MainWindow()
        {
            InitializeComponent();
        }
        string logadmin="admin";
        string passadmin = "admin";
        string loguser = "user1";
        string passuser = "user";
        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text != logadmin && login.Text != loguser)
            {
                tip.Text="Invalid login\ntry another one";
                login.Text = "";
                passwordbox.Password = "";
            } else
            if (passwordbox.Password != passadmin && passwordbox.Password != passuser)
            {
                 tip.Text="Invalid password\ntry another one";
                login.Text = "";
                passwordbox.Password = "";
            }
            if(logadmin == login.Text && passadmin == passwordbox.Password)
            {
                AdminWindow adminWindow = new AdminWindow();
                adminWindow.Show();
                this.Close();
            }
            if (loguser == login.Text && passuser == passwordbox.Password)
            {
                UserWindow userWindow = new UserWindow();
                userWindow.Show();
                this.Close();
            }
        }
    }
}
