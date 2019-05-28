using SelfmanagmentApp.Context;
using SelfmanagmentApp.Lock;
using System.Windows.Controls;
using System.Linq;
using System.Data.Entity;
using System.Windows;
using System.Collections.Generic;

namespace SelfmanagmentApp.View
{
    public partial class TaskUserControl : UserControl
    {
        UserContext _db = new UserContext();

        public TaskUserControl()
        {
            InitializeComponent();
            _db.Users.Load();
            var a = _db.Tasks
                .Where(f => f.TaskID == TokenUser.Token.User.UserID)
                .FirstOrDefault();
            /*
            txt1.Text = a.TaskOneValue;
            txt2.Text = a.TaskTwoValue;
            txt3.Text = a.TaskThreeValue;
            txt4.Text = a.LearningValue;
            txt5.Text = a.ThanksValue;
            txt6.Text = a.UpValue;
            */
            txt11.Text = a.TaskOneValue;
            txt12.Text = a.TaskOneTargetOneValue;
            txt13.Text = a.TaskOneTargetTwoValue;
            txt14.Text = a.TaskOneTargetThreeValue;
            txt15.Text = a.TaskOneTargetWhyValue;

            txt21.Text = a.TaskTwoValue;
            txt22.Text = a.TaskTwoTargetOneValue;
            txt23.Text = a.TaskTwoTargetTwoValue;
            txt24.Text = a.TaskTwoTargetThreeValue;
            txt25.Text = a.TaskTwoTargetWhyValue;

            txt31.Text = a.TaskThreeValue;
            txt32.Text = a.TaskThreeTargetOneValue;
            txt33.Text = a.TaskThreeTargetTwoValue;
            txt34.Text = a.TaskThreeTargetThreeValue;
            txt35.Text = a.TaskThreeTargetWhyValue;

            txt.Text = a.AwardValue;
            _db.SaveChanges();
        }

        /*
        private void ButtonSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _db.Users.Load();
            var a = _db.Tasks
                .Where(f => f.TaskID == TokenUser.Token.User.UserID)
                .FirstOrDefault();
            a.TaskOneValue = txt1.Text;
            a.TaskTwoValue = txt2.Text;
            a.TaskThreeValue = txt3.Text;
            a.LearningValue = txt4.Text;
            a.ThanksValue = txt5.Text;
            a.UpValue = txt6.Text;
            _db.SaveChanges();
            TokenUser.Token.User = _db.Users
                .Where(f => f.Email == TokenUser.Token.User.Email)
                .FirstOrDefault();
        }
        */

        private void Button1Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _db.Users.Load();
            var a = _db.Tasks
                .Where(f => f.TaskID == TokenUser.Token.User.UserID)
                .FirstOrDefault();
            a.TaskOneValue = txt11.Text;
            a.TaskOneTargetOneValue = txt12.Text;
            a.TaskOneTargetTwoValue = txt13.Text;
            a.TaskOneTargetThreeValue = txt14.Text;
            a.TaskOneTargetWhyValue = txt15.Text;
            _db.SaveChanges();
            TokenUser.Token.User = _db.Users
                .Where(f => f.Email == TokenUser.Token.User.Email)
                .FirstOrDefault();
        }

        private void Button2Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _db.Users.Load();
            var a = _db.Tasks
                .Where(f => f.TaskID == TokenUser.Token.User.UserID)
                .FirstOrDefault();
            a.TaskTwoValue = txt21.Text;
            a.TaskTwoTargetOneValue = txt22.Text;
            a.TaskTwoTargetTwoValue = txt23.Text;
            a.TaskTwoTargetThreeValue = txt24.Text;
            a.TaskTwoTargetWhyValue = txt25.Text;
            _db.SaveChanges();
            TokenUser.Token.User = _db.Users
                .Where(f => f.Email == TokenUser.Token.User.Email)
                .FirstOrDefault();
        }

        private void Button3Save_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _db.Users.Load();
            var a = _db.Tasks
                .Where(f => f.TaskID == TokenUser.Token.User.UserID)
                .FirstOrDefault();
            a.TaskThreeValue = txt31.Text;
            a.TaskThreeTargetOneValue = txt32.Text;
            a.TaskThreeTargetTwoValue = txt33.Text;
            a.TaskThreeTargetThreeValue = txt34.Text;
            a.TaskThreeTargetWhyValue = txt35.Text;
            _db.SaveChanges();
            TokenUser.Token.User = _db.Users
                .Where(f => f.Email == TokenUser.Token.User.Email)
                .FirstOrDefault();
        }

        private void ButtonSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            _db.Users.Load();
            var a = _db.Tasks
                .Where(f => f.TaskID == TokenUser.Token.User.UserID)
                .FirstOrDefault();
            a.AwardValue = txt.Text;
            _db.SaveChanges();
            TokenUser.Token.User = _db.Users
                .Where(f => f.Email == TokenUser.Token.User.Email)
                .FirstOrDefault();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog print = new System.Windows.Controls.PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(this.TasksWrap, "Списки");
            }
        }
    }
}
