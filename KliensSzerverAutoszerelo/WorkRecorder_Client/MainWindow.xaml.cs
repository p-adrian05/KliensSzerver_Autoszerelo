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
using WorkRecorder_Client.Models;

namespace WorkRecorder_Client {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void AddWork_Click(object sender, RoutedEventArgs e) {
            var window = new CustomerWindow(null);
            if (window.ShowDialog() ?? false) {
                
            }
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Work selectedWork = WorkListBox.SelectedItem as Work;
            if(selectedWork != null) {
                var window = new CustomerWindow(selectedWork);
                if (window.ShowDialog() ?? false) {

                }
                WorkListBox.UnselectAll();
            }
        }
    }
}
