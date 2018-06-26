using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Authenticate
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Config.AuthHelper auth = new Config.AuthHelper();
        public MainPage()
        {
            
           // string username = "abc";
         //-   string password = "xyz";
           // auth.AddUser(username, password);
            this.InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            //LoginLayer.Visibility = Model.Authentication.Authenticate1(txtName.Text, txtPassword.Text) ? Visibility.Collapsed : Visibility.Visible;
            
            string name=txtName.Text;
            string pass = txtPassword.Text;
           if( !Config.AuthHelper.Check(name,pass))
                Error.Text = "Username/Password does not match";
           else
            LoginLayer.Visibility = Model.Authentication.Authenticate1(txtName.Text, txtPassword.Text) ? Visibility.Collapsed : Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddUser));
        }
    }
}
