using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Facade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FacadeToAssembly _facadeToAssembly;
        public MainWindow()
        {
            InitializeComponent();
            _facadeToAssembly = new FacadeToAssembly();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _facadeToAssembly.StartProduction(productName.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _facadeToAssembly.StopProduction();
        }
    }
}