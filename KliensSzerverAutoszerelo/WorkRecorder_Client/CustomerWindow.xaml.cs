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
using WorkRecorder_Client.Validation;

namespace WorkRecorder_Client {
    public partial class CustomerWindow : Window {
        public CustomerWindow() {
            InitializeComponent();
            resetValidationLabales();
        }

        public void CreateButtonClick(object sender, RoutedEventArgs e) {
            resetValidationLabales();
            validateInput();
        }
        public void UpdateButtonClick(object sender, RoutedEventArgs e) {

        }
        public void DeleteButtonClick(object sender, RoutedEventArgs e) {

        }

        private bool validateInput() {
            try {
                CustomerValidation.validateFirstName(FirstNameTextBox.Text);
                CustomerValidation.validateLastName(LastNameTextBox.Text);
                CustomerValidation.validateBrandName(CarBrandTextBox.Text);
                CustomerValidation.validateCarType(CarTypeTextBox.Text);
                CustomerValidation.validateLicensePlateName(LicensePlateTextBox.Text);
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
