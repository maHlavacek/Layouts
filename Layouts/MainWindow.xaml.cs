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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                Window newWindow = null;
                switch(button.Content)
                {
                    case "StackPanel":
                        newWindow = new LayoutWindows.StackPanel();
                        break;

                    case "Dock":
                        newWindow = new LayoutWindows.Dock();
                        break;

                    case "Grid":
                        newWindow = new LayoutWindows.Grid();
                        break;

                    case "Grid Splitter":
                        newWindow = new LayoutWindows.GridSplitter();
                        break;
                }
                if (newWindow == null) throw new ArgumentNullException(nameof(button));
                else newWindow.Show();
            }
        }
    }
}
