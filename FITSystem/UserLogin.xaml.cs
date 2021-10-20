using FITSystem.Database;
using FITSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace FITSystem
{
    /// <summary>
    /// Interaction logic for UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
        }

        private void LblLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private async void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
                var validationResult = Validate(txtUser.Text, txtPassWd.Password);
                if (validationResult.Item1)
                {
                    LogUserLogin();


                    switch (validationResult.Item2)
                    {
                        case 0:
                            Navigate<DashB>();
                            break;

                        default:
                            MessageBox.Show("Error in Access Level");
                            //NotifyOverlay.Visibility = Visibility.Hidden;
                            return;
                    }

                    this.Close();
                }
     
            ///Slowing down happens at the click to establish the connection. For Better speed the connction establishment could be done in the form load. Hence the lag become invisible to user
        }


        //////////////////////////////////////------------------////////////////////////////////////////////
        //////////////////////////////////////------METHODS------////////////////////////////////////////////
        //////////////////////////////////////------------------////////////////////////////////////////////


        //////////////////////////////////////------------------////////////////////////////////////////////


        public void Navigate<TWin>() where TWin : Window, new()
        {
            TWin dashB = new TWin();
            dashB.Show();
            this.Close();
        }


        //////////////////////////////////////------------------////////////////////////////////////////////


        public (bool, int) Validate(string user, string passWd)
        {
            //Instantiating the DbConctext
            using (FitDb loginQuery = new FitDb())
            {
                var Tdata = loginQuery.EmployeeSet.Include(e => e.Login).Include(e => e.WorkRole.Permissions)
                    .FirstOrDefault(e => e.Login.Username == user && e.Login.Passwd == passWd);


                if (Tdata == null)
                {
                    MessageBox.Show("Invalid Username or Password");
                    return (false, -1);
                }

                //Actually unneccessary since checked at the query
                else if (user == Tdata.Login.Username & passWd == Tdata.Login.Passwd)
                {
                    return (true, Tdata.WorkRole.Permissions.PermId);
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                    //NotifyOverlay.Visibility = Visibility.Hidden;

                    return (false, -1);
                }
            }
        }

        //////////////////////////////////////------------------////////////////////////////////////////////


        public void LogUserLogin()
        {
            FitDb loginLogCtx = new FitDb();
            LoginLog log = new LoginLog()
            {
                EmplId = txtUser.Text,
                LoggedTs = DateTime.Now,
            };
            Global.EmplId = txtUser.Text;
            Global.LoginTs = log.LoggedTs;
            Global.IsUserLoggedIn = true;

            loginLogCtx.LoginLogSet.Add(log);
            loginLogCtx.SaveChanges();
        }

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}