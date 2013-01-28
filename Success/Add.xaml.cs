using System;
using System.IO.IsolatedStorage;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Success
{
    public partial class Add : PhoneApplicationPage
    {
        int[] Cents = { -2, -1, 0, 1, 2 };
        public Add()
        {
            InitializeComponent();
            Summ.ItemsSource = Cents;
        }

        public void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            String nulltext = NameToDo.Text.ToString();
            if (string.IsNullOrEmpty(NameToDo.Text))
            {
                MessageBox.Show("А название кто будет заполнять?");
            }
            else
            {

                String NameTo = NameToDo.Text.ToString();

                IsolatedStorageSettings.ApplicationSettings["Name"] = NameTo;

                int Sum = (int)Summ.SelectedItem;
                IsolatedStorageSettings.ApplicationSettings["Value"] = Sum;
                IsolatedStorageSettings.ApplicationSettings.Save();
                NavigationService.GoBack();
            }
        }
        public object stringint { get; set; }
    }
}