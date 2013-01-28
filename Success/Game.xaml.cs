using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;

namespace Success
{
    public partial class Game : PhoneApplicationPage
    {

        public List<string> ListP = new List<string>();
        public int sum = 0;   


        public Game()
        {
            InitializeComponent();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }

        public object NameLP { get; set; }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Name") == true)
            {
                FirstListBox.Items.Add(IsolatedStorageSettings.ApplicationSettings["Name"].ToString());
                int a = (int)IsolatedStorageSettings.ApplicationSettings["Value"];

                sum = sum + a;
                Total.Text = sum.ToString();
            }
            else
            {
            }

           
            base.OnNavigatedTo(e);
        }
    }
}