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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_laba_11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Apply(object sender, RoutedEventArgs e)
        {
            try
            {
                string fontFamily = (fontComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString();
                if (fontFamily == null) return;

                int fontSize = int.Parse((sizeComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "16");
                bool isBold = (styleComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() == "Bold";
                bool isItalic = (styleComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() == "Italic";
                bool isUnderlined = (styleComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() == "Underline";

                fontTB.FontFamily = new FontFamily(fontFamily);
                fontTB.FontSize = fontSize;
                fontTB.FontWeight = isBold ? FontWeights.Bold : FontWeights.Normal;
                fontTB.FontStyle = isItalic ? FontStyles.Italic : FontStyles.Normal;
                fontTB.TextDecorations = isUnderlined ? TextDecorations.Underline : null;
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ошибка формата: {ex.Message}");
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task2(object sender, RoutedEventArgs e)
        {
            zadanie2 z2 = new zadanie2();
            z2.Show();
            Close();
        }
    }
}