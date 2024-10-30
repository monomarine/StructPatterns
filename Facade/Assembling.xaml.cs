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
    /// Логика взаимодействия для Assembling.xaml
    /// </summary>
    public partial class Assembling : Window
    {
        public string Title { get;private set; }
        public Assembling(string title)
        {
            InitializeComponent();
            Title = title;
        }
        public void AcceptedToAssembly()
        {
            statusTB.Text = $"начата работа в соответствии с чертежом {Title}";
        }
        public void GetFinishedProduct()
        {
            statusTB.Text = $"изделие {Title} готово";
        }
    }
}
