using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Controls;
using System.Windows;



//1)Начинается с 50 очков.
//2)Игрок вносит успешные или не успешные дела
//и даёт им оченку в баллах.
//3) Итоговый результат не должен быть равен 0 

namespace Success
{
    public partial class Game : PhoneApplicationPage
    {

        public int sum=0;
       
        List<string> firstbox = new List<string>();
        List<string> bonuss = new List<string>();

        public Game()
        {
            InitializeComponent();
            Loaded += Game_Loaded;  
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Add.xaml", UriKind.Relative));
        }
  
        void Game_Loaded(object sender, RoutedEventArgs e)
        {            
            FirstListBox.ItemsSource = firstbox;
            Bonus.ItemsSource = bonuss;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Name") == true)
            {
                firstbox.Add(IsolatedStorageSettings.ApplicationSettings["Name"].ToString());

               int a = (int)IsolatedStorageSettings.ApplicationSettings["Value"];

                bonuss.Add(IsolatedStorageSettings.ApplicationSettings["Value"].ToString());
                
                sum = sum + a;
                Total.Text = sum.ToString();
                
            }
            //if (sum == 0)
            //{
            //    MessageBox.Show("Вы проиграли! Будте собранней!");
            //}
            base.OnNavigatedTo(e);
        }

       
    }
}