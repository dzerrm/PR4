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

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick_1(object sender, RoutedEventArgs e)
        {
            string a = Text1.Text;
            string b = Text2.Text;
            string c = "";
            int len_a = a.Length;
            int len_b = b.Length;
            if(len_a > 0 || len_b > 0)
                {
                c = a;
                a = b;
                b = c;
                Text1.Text = a;
                Text2.Text = b;
            }
            else
                {
                MessageBox.Show("Мінімум одне поле повинно містити текст", "Function error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnClick_2(object sender, RoutedEventArgs e)
        {
            string text = "Ви впевнені?";
            string title = "EXIT";

            MessageBoxResult result = MessageBox.Show(text, title, MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    Close();
                    break;

                case MessageBoxResult.Cancel:
                    break;
            }
        }
    }
}
