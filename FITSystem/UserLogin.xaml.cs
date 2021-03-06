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


        #region Methods
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

        public void Navigate<TWin>() where TWin : Window, new()
        {
            TWin dashB = new TWin();
            dashB.Show();
            this.Close();
        }

        public async Task<(bool, int)> ValidateAsync(string user, string passWd)
        {
            //Instantiating the DbConctext
            using (FitDb loginQuery = new FitDb())
            {
                var Tdata = await loginQuery.PersonSet.Include(e => e.Login)
                    .SingleOrDefaultAsync(e => e.Login.Username == user && e.Login.Passwd == passWd);


                if (Tdata == null)
                {
                    MessageBox.Show("Invalid Username or Password");
                    //NotifyOverlay.Visibility = Visibility.Hidden;
                    return (false, -1);
                }

                return (true, Tdata.WorkRole.RoleId);
            }
        }
        #endregion

        #region EventHandlers

        private void LblLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private async void BtnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            var validationResult = await ValidateAsync(txtUser.Text, txtPassWd.Password);
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

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        #endregion
    }
}