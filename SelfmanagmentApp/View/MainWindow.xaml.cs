using SelfmanagmentApp.Context;
using SelfmanagmentApp.IO;
using SelfmanagmentApp.Lock;
using SelfmanagmentApp.View;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace SelfmanagmentApp
{
    public partial class MainWindow : Window
    {
        UserContext _db = new UserContext();

        public MainWindow()
        {
            InitializeComponent();
            imgUser1.ImageSource = ImageIO.ByteToBitmapImage(TokenUser.Token.User.Avatar);
            imgUser2.ImageSource = ImageIO.ByteToBitmapImage(TokenUser.Token.User.Avatar);
            txtUser.Text = TokenUser.Token.User.Name;
            UpdateTaskCount();
            HelpControl();
        }

        public void UpdateTaskCount()
        {
            _db.ListDeals.Load();
            int taskCount = _db.Planings.Where(f => f.UserID == TokenUser.Token.User.UserID).Count();
            txtAllTasks.Text = TasksText(taskCount);
            int finishTaskCount = _db.Planings.Where(f => (f.UserID == TokenUser.Token.User.UserID) && (f.StatusPlaning == true)).Count();
            txtFinishTasks.Text = TasksText(finishTaskCount);
        }

        private string TasksText(int taskCount)
        {
            string taskTxt = taskCount.ToString() + " задач";
            if (taskCount != 0 && (taskCount < 11 || taskCount > 19))
            {
                double mod = taskCount % 10;

                if (mod == 1)
                {
                    taskTxt += "а";
                }
                else if (mod == 2 || mod == 3 || mod == 4)
                {
                    taskTxt += "и";
                }
            }
            return taskTxt;
        }

        public void HelpControl()
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new HelpUserControl());
        }

        public void ListControl()
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new ListUserControl());
        }

        public void TaskControl()
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new TaskUserControl());
        }

        public void PlaningControl()
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new PlaningUserControl());
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            UpdateTaskCount();
        }

        private void ButtonClose_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /*
        private void ListViewItem4_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            HelpControl();
        }

        private void ListViewItem3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListControl();
        }

        private void ListViewItem2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TaskControl();
        }

        private void ListViewItem1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlaningControl();
        }
        */

        private void ListViewItem1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PlaningControl();
        }

        private void ListViewItem2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TaskControl();
        }

        private void ListViewItem3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListControl();
        }

        private void ListViewItem4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HelpControl();
        }
    }
}
