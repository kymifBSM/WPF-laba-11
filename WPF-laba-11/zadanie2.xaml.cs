using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_laba_11
{
    /// <summary>
    /// Логика взаимодействия для zadanie2.xaml
    /// </summary>
    public partial class zadanie2 : Window
    {
        public zadanie2()
        {
            InitializeComponent();

            gamesCB.Items.Add("The Elder Scrolls III: Morrowind");
            gamesCB.Items.Add("S.T.A.L.K.E.R. Чистое Небо");
            gamesCB.Items.Add("The Elder Scrolls IV: Oblivion");

            programmsCB.Items.Add("C# za 1 chas");
            programmsCB.Items.Add("C# za 24 chasa");
            programmsCB.Items.Add("C# za 168 chasov");
        }

        private void AddToOrder(object sender, RoutedEventArgs e)
        {
            string selectedGame = gamesCB.SelectedItem as string;
            string selectedProgramm = programmsCB.SelectedItem as string;

            if (selectedGame != null)
            {
                orderLB.Items.Add(selectedGame + " (игра)");
                gamesCB.SelectedItem = null;
            }

            if (selectedProgramm != null)
            {
                orderLB.Items.Add(selectedProgramm + " (обучающая программа)");
                programmsCB.SelectedItem = null;
            }

            UpdateOrderCount();
        }


        private void DeleteFromOrder(object sender, RoutedEventArgs e)
        {
            if (orderLB.SelectedIndex != -1)
            {
                orderLB.Items.RemoveAt(orderLB.SelectedIndex);
                UpdateOrderCount();
            }
        }

        private void UpdateOrderCount()
        {
            int count = orderLB.Items.Count;
            orderCountL.Content = $"Количество заказов: {count}";
        }
    }
}