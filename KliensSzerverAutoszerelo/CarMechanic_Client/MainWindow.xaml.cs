using KliensSzerverAutoszerelo_Common.DataProviders;
using KliensSzerverAutoszerelo_Common.Models;
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

namespace CarMechanic_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IList<Work> _works;
        public MainWindow()
        {
            InitializeComponent();

            UpdateWorks();
        }

        private void WorksListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UpdateWorks()
        {
            _works = WorkDataProvider.GetWorks().ToList();
            WorksListBox.ItemsSource = _works;
            
        }
    }
}
