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
using KliensSzerverAutoszerelo_Common.DataProviders;
using KliensSzerverAutoszerelo_Common.Models;

namespace WorkRecorder_Client {

    public partial class MainWindow : Window {

        private IList<Work> _works;
        public MainWindow() {
            InitializeComponent();

            UpdateWorkListBox();
        }
        private void AddWork_Click(object sender, RoutedEventArgs e) {
            var window = new CustomerWindow(null);
            if (window.ShowDialog() ?? false) {
                UpdateWorkListBox();
            }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Work selectedWork = WorkListBox.SelectedItem as Work;
            if(selectedWork != null) {
                var window = new CustomerWindow(selectedWork);
                if (window.ShowDialog() ?? false) {
                    UpdateWorkListBox();
                }
                WorkListBox.UnselectAll();
            }
        }

        private void UpdateWorkListBox() {
            _works = (IList<Work>)WorkDataProvider.GetWorks();
            WorkListBox.ItemsSource = _works;
        }
    }
}
