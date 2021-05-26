using FITSystem.Database;
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
            //NotifyOverlay.Visibility = Visibility.Visible;
            await Task.Delay(250);
            var ValidationResult = Validate(txtUser.Text, txtPassWd.Password);
            if (ValidationResult.Item1)
            {
                LogUserLogin();




                switch (ValidationResult.Item2)
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
        //////////////////////////////////////------METHOD------////////////////////////////////////////////
        //////////////////////////////////////------------------////////////////////////////////////////////



        //////////////////////////////////////------------------////////////////////////////////////////////
        

        public void Navigate<Win>() where Win: Window, new()
        {
            Win Dash_B = new Win();
            Dash_B.Show();
            this.Close();
        }

        
        //////////////////////////////////////------------------////////////////////////////////////////////
        


        public (bool, int) Validate(string User, string PassWd)
        {

            database LoginQuerry = new database();
            var Data = LoginQuerry.Login_Set.Where(u => u.UserID == User).FirstOrDefault();

            if (Data == null)
            {
                MessageBox.Show("UsedID Not Found");
                //NotifyOverlay.Visibility = Visibility.Hidden;

                return (false, -1);
            }
            else if (User == Data.UserID & PassWd == Data.PassWd)
            {

                return (true, Data.AccessLevel);
            }
            else
            {
                MessageBox.Show("Invalid Password");
                //NotifyOverlay.Visibility = Visibility.Hidden;

                return (false, -1);
            }
        }

        //////////////////////////////////////------------------////////////////////////////////////////////
        

        public void LogUserLogin()
            {
                database LoginLogCtx = new database();
                UserLoginLog Log = new UserLoginLog
                {
                    UserID = txtUser.Text,
                    LoggedTS = DateTime.Now,

                };
                Global.UserID = txtUser.Text;
                Global.LoginTS = Log.LoggedTS;
                Global.IsUserLoggedIn = true;

                LoginLogCtx.LoginLog_Set.Add(Log);
                LoginLogCtx.SaveChanges();

            }
    }
}
