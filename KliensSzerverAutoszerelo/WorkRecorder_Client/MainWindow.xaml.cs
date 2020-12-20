using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using KliensSzerverAutoszerelo_Common.DataProviders;
using KliensSzerverAutoszerelo_Common.Models;
using System;
using System.Windows.Media;

namespace WorkRecorder_Client
{

    public partial class MainWindow : Window {

        private IList<Work> _works;
        public MainWindow() {
            InitializeComponent();
            ErrorLabel.Content = "";
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
            try {
                _works = (IList<Work>)WorkDataProvider.GetWorks();
            }catch(InvalidOperationException ex) {
                ShowErrorMessage(ErrorLabel, ex.Message);
            }
            WorkListBox.ItemsSource = _works;
        }

        private void ShowErrorMessage(Label label, String message) {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }
    }
}
