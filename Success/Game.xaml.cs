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
        int[] Cents = { -15, -10, -5, 0, 5, 10, 15 };
        int sum;
       int inc;

        List<string> firstbox = new List<string>();
        List<string> bonuss = new List<string>();

        public Game()
        {
            InitializeComponent();
           // Loaded += Game_Loaded;
            Summ.ItemsSource = Cents;
            Total.Text = "50";
            sum = 50;
           
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            firstbox.Add(NameToDo.Text.ToString());
            bonuss.Add(Summ.SelectedItem.ToString());
            inc = (int)Summ.SelectedItem;
            sum = sum + inc;
            Total.Text = sum.ToString();
            FirstListBox.ItemsSource = firstbox;
            Bonus.ItemsSource = bonuss;

            //if (IsolatedStorageSettings.ApplicationSettings.Contains("Name") == true)
            //{
            //    inc = (string)IsolatedStorageSettings.ApplicationSettings["Name"];
            //    firstbox.Add(inc);
            //    sum = (int)IsolatedStorageSettings.ApplicationSettings["Value"];
            //    bonuss.Add(sum.ToString());

            //}
        }

        //void Game_Loaded(object sender, RoutedEventArgs e)
        //{
           
        //}

        //protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        //{
           
            

        //    base.OnNavigatedTo(e);
        //}



    }
}