using SelfmanagmentApp.Context;
using SelfmanagmentApp.Lock;
using System.Data.Entity;
using System.Windows.Controls;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System;

namespace SelfmanagmentApp.View
{
    public partial class PlaningUserControl : UserControl
    {
        UserContext _db = new UserContext();

        List<PlaningUser> a;

        public PlaningUserControl()
        {
            InitializeComponent();
            _db.Planings.Load();
            a = _db.Planings
                .Where(f => f.UserID == TokenUser.Token.User.UserID)
                .ToList();
            MainGrid.ItemsSource = a;
        }

        private void ButtonUpdate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _db.Planings.Load();
            _db.SaveChanges();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _db.Planings.Load();
            _db.Planings
                .Add
                (
                new PlaningUser()
                { UserID = TokenUser.Token.User.UserID, NamePlaning = txtPlaning.Text, TimePlaning = DateTime.Now.ToString()}
                );
            _db.SaveChanges();
                        a = _db.Planings
                .Where(f => f.UserID == TokenUser.Token.User.UserID)
                .ToList();
            MainGrid.ItemsSource = a;
        }
    }
}
