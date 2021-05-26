using FITSystem.Database;
using FITSystem.Models;
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
            var ValidationResult = Validate(txtPassWd.Password, txtPassWd.Password);
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
            var Data = LoginQuerry.LOGIN_SET.Include("WORK_ROLE.PERMISSIONS").Where(u => u.Username == User).FirstOrDefault();

            if (Data == null)
            {
                MessageBox.Show("UsedID Not Found");
                //NotifyOverlay.Visibility = Visibility.Hidden;

                return (false, -1);
            }
            else if (User == Data.Username & PassWd == Data.Passwd)
            {

                return (true, Data.WORK_ROLE.PERMISSIONS.Perm_id);
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
                LOGIN_LOG Log = new LOGIN_LOG()
                {
                    Empl_id = txtUser.Text,
                    LoggedTS = DateTime.Now,

                };
                Global.Empl_id = txtUser.Text;
                Global.LoginTS = Log.LoggedTS;
                Global.IsUserLoggedIn = true;

                LoginLogCtx.LOGIN_LOG_SET.Add(Log);
                LoginLogCtx.SaveChanges();

            }
    }
}
