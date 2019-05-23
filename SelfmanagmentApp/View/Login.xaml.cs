using SelfmanagmentApp.Context;
using System.Data.Entity;
using System.Windows;
using System.Linq;
using SelfmanagmentApp.IO;
using SelfmanagmentApp.Lock;

namespace SelfmanagmentApp
{
    public partial class Login : Window
    {
        UserContext _db = new UserContext();

        public Login()
        {
            InitializeComponent();
            _db.Users.Load();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            _db.Users.Load();
            try
            {
                if (_db.Users
                    .Where(f => f.Email == txtUserName.Text)
                    .ToList()
                    .FirstOrDefault()
                    .Hashpass == StringIO.GetSHA256(txtUserPass.Password))
                {
                    TokenUser.CreateToken(_db.Users
                    .Where(f => f.Email == txtUserName.Text)
                    .ToList()
                    .FirstOrDefault());
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
