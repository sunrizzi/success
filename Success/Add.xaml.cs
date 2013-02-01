using System;
using System.IO.IsolatedStorage;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Success
{
    public partial class Add : PhoneApplicationPage
    {
        int[] Cents = { -10, -5, 0, 5, 10 };

        public Add()
        {
            InitializeComponent();
            Summ.ItemsSource = Cents;
        }

        public void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NameToDo.Text))
            {
                MessageBox.Show("А название кто будет заполнять?");
            }
            else
            {

                IsolatedStorageSettings.ApplicationSettings["Name"] = NameToDo.Text.ToString();

                IsolatedStorageSettings.ApplicationSettings["Value"] = (int)Summ.SelectedItem;

                IsolatedStorageSettings.ApplicationSettings.Save();

              // NavigationService.GoBack();
                NavigationService.Navigate(new Uri("/Game.xaml", UriKind.Relative));
               
            }
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {

            
            base.OnBackKeyPress(e);
        }
    }
}