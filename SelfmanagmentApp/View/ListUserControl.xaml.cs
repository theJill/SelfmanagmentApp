using SelfmanagmentApp.Context;
using SelfmanagmentApp.Lock;
using System.Data.Entity;
using System.Windows.Controls;
using System.Linq;
using System.Windows;

namespace SelfmanagmentApp.View
{
    public partial class ListUserControl : UserControl
    {
        UserContext _db = new UserContext();

        public ListUserControl()
        {
            InitializeComponent();
            UpdateList();
        }

        public void UpdateList()
        {
            DealStack.Children.Clear();
            _db.ListDeals.Load();
            _db.ListDeals
                .Where(f => f.UserID == TokenUser.Token.User.UserID)
                .ToList()
                .ForEach(v => DealStack.Children.Add(new DealUserControl(v)));
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (txtDeal.Text != "")
            {
                _db.ListDeals.Load();
                _db.ListDeals
                    .Add(
                    new ListDeal()
                    { UserID = TokenUser.Token.User.UserID, Value = txtDeal.Text}
                    );
                _db.SaveChanges();
                txtDeal.Text = "";
                MessageBox.Show("Done!");
            }
            UpdateList();
        }
    }
}
