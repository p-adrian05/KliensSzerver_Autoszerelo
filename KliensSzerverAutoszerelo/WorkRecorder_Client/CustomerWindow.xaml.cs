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
using System.Text.RegularExpressions;

namespace WorkRecorder_Client {
    public partial class CustomerWindow : Window {
        public CustomerWindow() {
            InitializeComponent();
            resetValidationLabales();
        }

        public void CreateButtonClick(object sender, RoutedEventArgs e) {
            resetValidationLabales();
            validateCustomer();
        }
        public void UpdateButtonClick(object sender, RoutedEventArgs e) {

        }
        public void DeleteButtonClick(object sender, RoutedEventArgs e) {

        }

        private bool validateCustomer() {
            try {
                validateFirstName(FirstNameTextBox.Text);
                validateLastName(LastNameTextBox.Text);
                validateBrandName(CarBrandTextBox.Text);
                validateCarType(CarTypeTextBox.Text);
                validateLicensePlateName(LicensePlateTextBox.Text);
                return true;
            }catch(InvalidFirstNameException e) {
                showErrorMessage(FirstNameErrLabel, e.Message);
            }catch(InvalidLastNameException e) {
                showErrorMessage(LastNameErrLabel, e.Message);
            }catch(InvalidBrandNameException e) {
                showErrorMessage(CarBrandErrLabel, e.Message);
            }catch (InvalidCarTypeException e) {
                showErrorMessage(CarTypeErrLabel, e.Message);
            }catch (InvalidLicensePlateException e) {
                showErrorMessage(LicensePlateErrLabel, e.Message);
            }
            return false;
        }

        private bool validateFirstName(String name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new InvalidFirstNameException("FirstName should not be empty.");
            } else if(!Regex.IsMatch(name,@"^([A-Z][a-z]*)?(\s{0,1}[A-Z][a-z]*)$")){
                throw new InvalidFirstNameException("Invalid first name");
            }
            return true;
        }
        private bool validateLastName(String name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new InvalidLastNameException("Last Name should not be empty.");
            } else if (!Regex.IsMatch(name, @"^[A-Z][a-z]*$")) {
                throw new InvalidLastNameException("Invalid last name");
            }
            return true;
        }
        private bool validateBrandName(String brandName) {
            if (string.IsNullOrWhiteSpace(brandName)) {
                throw new InvalidBrandNameException("Brand name should not be empty.");
            } else if (!Regex.IsMatch(brandName, @"^[A-Z][a-z]*$")) {
                throw new InvalidBrandNameException("Invalid brand");
            }
            return true;
        }
        private bool validateLicensePlateName(String licensePlate) {
            if (string.IsNullOrWhiteSpace(licensePlate)) {
                throw new InvalidLicensePlateException("License plate should not be empty.");
            } else if (!Regex.IsMatch(licensePlate, @"^[A-Z0-9]{6}$")) {
                throw new InvalidLicensePlateException("Only capital letters and numbers and max 6 character. ");
            }
            return true;
        }
        private bool validateCarType(String carTypeName) {
            if (string.IsNullOrWhiteSpace(carTypeName)) {
                throw new InvalidCarTypeException("Car type should not be empty.");
            } else if (!Regex.IsMatch(carTypeName, @"^(\w*(\s*))*$")) {
                throw new InvalidCarTypeException("No special characters allowed");
            }
            return true;
        }
        private void resetValidationLabales() {
            FirstNameErrLabel.Content = "";
            LastNameErrLabel.Content = "";
            CarBrandErrLabel.Content = "";
            CarTypeErrLabel.Content = "";
            LicensePlateErrLabel.Content = "";
            DescriptionErrLabel.Content = "";
        }

        private void showErrorMessage(Label label,String message) {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }

        private void CarTypeTextBox_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}
