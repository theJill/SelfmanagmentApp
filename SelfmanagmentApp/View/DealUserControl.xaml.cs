using SelfmanagmentApp.Context;
using System;
using System.Windows.Controls;

namespace SelfmanagmentApp.View
{
    public partial class DealUserControl : UserControl
    {
        private DealUserControl()
        {
            InitializeComponent();
        }

        public DealUserControl(ListDeal listDeal)
        {
            InitializeComponent();
            txtID.Text = Convert.ToString(listDeal.ListDealID);
            txtValue.Text = listDeal.Value;
        }
    }
}
