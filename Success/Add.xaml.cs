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
            // String NameTo = NameToDo.Text.ToString();
            if (string.IsNullOrEmpty(NameToDo.Text))
            {
                MessageBox.Show("А название кто будет заполнять?");
            }
            else
            {

                String NameTo = NameToDo.Text.ToString();
                int Sum = (int)Summ.SelectedItem;

                IsolatedStorageSettings.ApplicationSettings["Name"] = NameTo;
                IsolatedStorageSettings.ApplicationSettings["Value"] = Sum;
                IsolatedStorageSettings.ApplicationSettings.Save();



                NavigationService.GoBack();
            }
        }
        public object stringint { get; set; }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("А название кто будет заполнять?");
            e.Cancel = true;
            base.OnBackKeyPress(e);
        }
    }
}