using SelfmanagmentApp.IO;
using SelfmanagmentApp.Lock;
using SelfmanagmentApp.View;
using System.Windows;
using System.Windows.Input;

namespace SelfmanagmentApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            imgUser1.ImageSource = ImageIO.ByteToBitmapImage(TokenUser.Token.User.Avatar);
            imgUser2.ImageSource = ImageIO.ByteToBitmapImage(TokenUser.Token.User.Avatar);
            txtUser.Text = TokenUser.Token.User.Name;
            HelpControl();
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
        }

        private void ButtonClose_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

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
    }
}
