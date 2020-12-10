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

namespace WorkRecorder_Client {
    /// <summary>
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window {
        public CustomerWindow() {
            InitializeComponent();
        }

        public void CreateButtonClick(object sender, RoutedEventArgs e) {
            validateCustomer();
        }
        public void UpdateButtonClick(object sender, RoutedEventArgs e) {

        }
        public void DeleteButtonClick(object sender, RoutedEventArgs e) {

        }

        private void validateCustomer() {

            if (string.IsNullOrEmpty(FirstNameTextBox.Text)) {
                showWarningMessage(FirstNameErrLabel, "First name should not be empty.");
            }
            if (string.IsNullOrEmpty(LastNameTextBox.Text)) {
                showWarningMessage(LastNameErrLabel, "Last name should not be empty.");
            }
        }

        private void showWarningMessage(Label label,String message) {
            label.Content = "First name should not be empty.";
            label.Foreground = Brushes.Red;
        }

        private void CarTypeTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
