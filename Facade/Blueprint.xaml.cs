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

namespace Facade
{
    /// <summary>
    /// Логика взаимодействия для Blueprint.xaml
    /// </summary>
    public partial class Blueprint : Window
    {
        public string Title { get;private set; }    
        public Blueprint(string title)
        {
            InitializeComponent();
            Postponed();
            Title = title;
        }
        public void ReadyToWork()
        {  
            statusTB.Text = $"чертеж {Title} передан в работу";
        }

        public void Postponed()
        {
            statusTB.Text = $"чертеж {Title} отложен";
        }
    }
}
