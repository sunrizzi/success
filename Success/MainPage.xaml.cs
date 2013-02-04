using System;
using System.Windows;
using Microsoft.Phone.Controls;
using System.ComponentModel;
using System.Windows.Controls.Primitives;
using System.Threading;
using Microsoft.Phone.Shell;
using System.Linq;
using System.Windows.Input;



namespace Success
{
    public partial class MainPage : PhoneApplicationPage
    {
        BackgroundWorker bkworker;
        Popup myPopup;
        int[] Cents = { -15, -10, -5, 0, 5, 10, 15 };
        int sum;

        string[] GItems;

        string FullString;
        // Конструктор
        public MainPage()
        {
            InitializeComponent();
            bkworker = new BackgroundWorker();
            myPopup = new Popup() { IsOpen = true, Child = new SplashLog() };
            RunBackroundWorker();


            Loaded += Game_Loaded;
            Summ.ItemsSource = Cents;
            Total.Text = "100";
            sum = 100;

            this.NameToDo.KeyUp += new KeyEventHandler(NameToDo_KeyUp);

        }

        void Game_Loaded(object sender, RoutedEventArgs e)
        {
            //  FirstListBox.ItemsSource = GItems;
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


        }

        private void StartBt_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameToDo.Text.ToString()))
            {
                MessageBox.Show("Нет названия!");

            }
            else
            {
                FullString = Summ.SelectedItem.ToString() + "    " + NameToDo.Text.ToString();
                FirstListBox.Items.Add(FullString);

                NameToDo.Text = "";
                sum = sum + (int)Summ.SelectedItem;
                Total.Text = sum.ToString();

            }


        }


        public void TileUpdate()
        {


            var apptile = ShellTile.ActiveTiles.First();
            var appTileData = new StandardTileData();
            appTileData.BackContent = "Баллы: ";
            appTileData.Count = 0;
            appTileData.BackgroundImage = new Uri("/TilePic.png", UriKind.RelativeOrAbsolute);


            apptile.Update(appTileData);
        }



        private void RunBackroundWorker()
        {
            bkworker.DoWork += ((s, args) =>
            {
                Thread.Sleep(1000);
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