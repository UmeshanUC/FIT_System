using FITSystem.Classes;
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

namespace FITSystem.FITPages
{
    /// <summary>
    /// Interaction logic for Dash_Staff.xaml
    /// </summary>
    public partial class Dash_Staff : Page
    {
        public Dash_Staff()
        {
            InitializeComponent();
            cardMed.DataContext = new DetailCard()
            {
                CardName = "Medical Officers",
                TotalEmployed = 10,
                TodayOnWork = 5,
                TotalOther = 3
            };
            cardMembers.DataContext = new DetailCard()
            {
                CardName = "Members",
                TotalEmployed = 100,
                TodayOnWork = 50,
                TotalOther = 3
            };
            cardTrainers.DataContext = new DetailCard()
            {
                CardName = "Trainers",
                TotalEmployed = 35,
                TodayOnWork = 20,
                TotalOther = 2
            };
            cardOther.DataContext = new DetailCard()
            {
                CardName = "Other Staff",
                TotalEmployed = 20,
                TodayOnWork = 16,
                TotalOther = 1
            };
        }

        private void DetailCard_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
