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