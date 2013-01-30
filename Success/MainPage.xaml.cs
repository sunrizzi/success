using System;
using System.Windows;
using Microsoft.Phone.Controls;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
using System.Threading;

namespace Success
{
    public partial class MainPage : PhoneApplicationPage
    {
        BackgroundWorker bkworker;
        Popup myPopup;
        // Конструктор
        public MainPage()
        {
            InitializeComponent();
            bkworker = new BackgroundWorker();
            myPopup = new Popup() { IsOpen = true, Child = new SplashLog() };
            RunBackroundWorker();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Game.xaml", UriKind.Relative));
        }

       

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        private void RunBackroundWorker()
        {
            bkworker.DoWork += ((s, args) =>
            {
                Thread.Sleep(5000);
            });

            bkworker.RunWorkerCompleted += ((s, args) =>
            {
                this.Dispatcher.BeginInvoke(() =>
                {
                    this.myPopup.IsOpen = false;
                }
                );
            });
            bkworker.RunWorkerAsync();
        }
    }
}