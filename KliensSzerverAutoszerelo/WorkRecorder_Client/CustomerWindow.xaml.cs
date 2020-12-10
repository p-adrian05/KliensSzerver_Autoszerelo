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
            resetValidationLabales();
            validateCustomer();
        }
        public void UpdateButtonClick(object sender, RoutedEventArgs e) {

        }
        public void DeleteButtonClick(object sender, RoutedEventArgs e) {

        }

        private void validateCustomer() {

            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text)) {
                showWarningMessage(FirstNameErrLabel, "First name should not be empty.");
            }
            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text)) {
                showWarningMessage(LastNameErrLabel, "Last name should not be empty.");
            }
            if (string.IsNullOrWhiteSpace(CarBrandTextBox.Text)) {
                showWarningMessage(CarBrandErrLabel, "Car brand should not be empty.");
            }
            if (string.IsNullOrWhiteSpace(CarTypeTextBox.Text)) {
                showWarningMessage(CarTypeErrLabel, "Car type should not be empty.");
            }
            if (string.IsNullOrWhiteSpace(LicensePlateTextBox.Text)) {
                showWarningMessage(LicensePlateErrLabel, "License plate should not be empty.");
            }
        }
        private void resetValidationLabales() {
            FirstNameErrLabel.Content = "";
            LastNameErrLabel.Content = "";
            CarBrandErrLabel.Content = "";
            CarTypeErrLabel.Content = "";
            LicensePlateErrLabel.Content = "";
        }

        private void showWarningMessage(Label label,String message) {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }

        private void CarTypeTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
