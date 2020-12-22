using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using KliensSzerverAutoszerelo_Common.DataProviders;
using KliensSzerverAutoszerelo_Common.Models;
using System;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace WorkRecorder_Client
{

    public partial class MainWindow : Window {

        private Collection<Work> _works;
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
            Work selectedWork = WorkListView.SelectedItem as Work;
            if(selectedWork != null) {
                var window = new CustomerWindow(selectedWork);
                if (window.ShowDialog() ?? false) {
                    UpdateWorkListBox();
                }
                WorkListView.UnselectAll();
            }
        }

        private void UpdateWorkListBox() {
            try {
                _works = new ObservableCollection<Work>(WorkDataProvider.GetWorks());
            }catch(InvalidOperationException ex) {
                ShowErrorMessage(ErrorLabel, ex.Message);
            }
            WorkListView.ItemsSource = _works;
        }

        private void ShowErrorMessage(Label label, String message) {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }
    }
}
