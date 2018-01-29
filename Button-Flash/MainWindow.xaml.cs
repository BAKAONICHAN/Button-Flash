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

namespace Button_Flash
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int way;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GoMove_Click(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            way = rand.Next(4);
            if (way==1)
                TryToCatch.VerticalAlignment = VerticalAlignment.Bottom;
            else if(way==2)
                TryToCatch.VerticalAlignment = VerticalAlignment.Top;

           else  if (way==3)
                TryToCatch.HorizontalAlignment = HorizontalAlignment.Left;
            else if(way==4)
                TryToCatch.HorizontalAlignment = HorizontalAlignment.Right;
        }

    }
}
