using KliensSzerverAutoszerelo_Common.DataProviders;
using KliensSzerverAutoszerelo_Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Collection<Work> _works;
        public MainWindow()
        {
            InitializeComponent();

            UpdateWorks();
        }


        private void UpdateWorks()
        {
            try{
                _works = new ObservableCollection<Work>(WorkDataProvider.GetWorks());

                WorkListView.ItemsSource = _works;
            }
            catch (InvalidOperationException e){
                ShowErrorMessage(ErrorLabel, e.Message);
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Work selectedWork = WorkListView.SelectedItem as Work;
            if (selectedWork != null)
            {
                var window = new UpdateWorkStateWindow(selectedWork);
                if (window.ShowDialog() ?? false)
                {
                    UpdateWorks();
                }
                WorkListView.UnselectAll();
            }

        }

        private void ShowErrorMessage(Label label, String message)
        {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }
    }
}
