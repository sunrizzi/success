using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Controls;
using System.Windows;
using System.Windows.Input;


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
        List<string> firstbox = new List<string>();
        List<string> bonuss = new List<string>();

        public Game()
        {
            InitializeComponent();
            Loaded += Game_Loaded;
            Summ.ItemsSource = Cents;
            Total.Text = "50";
            sum = 50;
            this.NameToDo.KeyUp += new KeyEventHandler(NameToDo_KeyUp);
            FirstListBox.ItemsSource = firstbox;
        }

        void Game_Loaded(object sender, RoutedEventArgs e)
        {

        }

        void NameToDo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.Focus();
                LoadFlush();
            }
        }

        void LoadFlush()
        {
            string SummString = Summ.SelectedItem.ToString();
            string NameString = NameToDo.Text.ToString();
            string FullString = SummString + "    " + NameString;
            firstbox.Add(FullString);
            NameToDo.Text = "";
            sum = sum + (int)Summ.SelectedItem;
            Total.Text = sum.ToString();

        }
    }
}