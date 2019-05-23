using SelfmanagmentApp.Context;
using SelfmanagmentApp.Lock;
using System.Windows.Controls;
using System.Linq;
using System.Data.Entity;
using System.Windows;

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
            txt1.Text = a.TaskOneValue;
            txt2.Text = a.TaskTwoValue;
            txt3.Text = a.TaskThreeValue;
            txt4.Text = a.LearningValue;
            txt5.Text = a.ThanksValue;
            txt6.Text = a.UpValue;
            _db.SaveChanges();
        }

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
    }
}
