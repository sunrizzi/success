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
        
        int sum;
        public string inc;
       
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
          //  FirstListBox.ItemsSource = firstbox;
          //  Bonus.ItemsSource = bonuss;
            sum = 50;


        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
           
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Value") == false)
            {
                Total.Text = "50";
                if (IsolatedStorageSettings.ApplicationSettings.Contains("Name") == true)
                {
                    inc = (string)IsolatedStorageSettings.ApplicationSettings["Name"];
                }
            }else
                if (String.CompareOrdinal(IsolatedStorageSettings.ApplicationSettings["Name"].ToString(), inc) == 0)

                {

                    

                }
                else
                {
                    
                    String name1 = IsolatedStorageSettings.ApplicationSettings["Name"].ToString();
                    firstbox.Add(name1);
                    bonuss.Add(IsolatedStorageSettings.ApplicationSettings["Value"].ToString());
                    sum = sum + (int)IsolatedStorageSettings.ApplicationSettings["Value"];
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