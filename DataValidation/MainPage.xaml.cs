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

namespace DataValidation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)

        {

        }


    
      #region UserName



        private string _UserName;



        public string UserName

        {

            get { return _UserName; }



            set

            {

                _UserName = value;

            }

        }



        #endregion



        #region EmailID



        private string _EmailID;



        public string EmailID

        {

            get { return _EmailID; }



            set

            {

                _EmailID = value;

            }

        }



        #endregion



        #region word



        private string _word;



        public string word

        {

            get { return _word; }



            set { _word = value; }

        }



        #endregion



        #region Age



        private string _Age;



        public string Age

        {

            get { return _Age; }



            set

            {

                _Age = value;

            }

        }

        #endregion



        private void Button_Click_1(object sender, RoutedEventArgs e)

        {

            if (txtUserName.Text.Length < 6)

            {

                namvalidate.Visibility = Windows.UI.Xaml.Visibility.Visible;

                namvalidate.Text = "User Name should contain atleast 6 chars";

            }



            if (!txtEmailID.Text.Contains("@") || !txtEmailID.Text.Contains("."))

            {

                emailvalidate.Visibility = Windows.UI.Xaml.Visibility.Visible;

                emailvalidate.Text = "Invalid Email ID";

            }



            if (Convert.ToInt32(txtAge.Text) < 18 || Convert.ToInt32(txtAge.Text) > 40)

            {



                agevalidate.Visibility = Windows.UI.Xaml.Visibility.Visible;

                agevalidate.Text = "Age should be range in 18 ~ 40";

            }

        }
    }
}
