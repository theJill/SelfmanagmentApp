using Microsoft.Win32;
using SelfmanagmentApp.Context;
using System;
using System.Data.Entity;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SelfmanagmentApp
{
    public partial class Registration : Window
    {
        BitmapImage imgAvatar;

        UserContext _db = new UserContext();

        public Registration()
        {
            InitializeComponent();
            _db.Users.Load();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            _db.Users.Add(
                new User(txtUserName.Text, txtUserPass.Password, txtUserEmail.Text, imgAvatar)
                );
            _db.SaveChanges();
            MessageBox.Show("Done!");
            Close();
        }

        private void BtnLoadAvatar_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                OpenFileDialog op = new OpenFileDialog();
                op.Title = "Select a picture";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                  "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                  "Portable Network Graphic (*.png)|*.png";
                if (op.ShowDialog() == true)
                {
                    imgAvatar = new BitmapImage(new Uri(op.FileName));
                }
            //}
            //catch
            //{
                
            //}
        }
    }
}
