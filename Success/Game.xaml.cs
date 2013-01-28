using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Controls;

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