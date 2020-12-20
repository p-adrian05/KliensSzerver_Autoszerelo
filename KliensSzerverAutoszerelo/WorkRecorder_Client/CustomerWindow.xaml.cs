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
using KliensSzerverAutoszerelo_Common.Models;
using KliensSzerverAutoszerelo_Common.DataProviders;

namespace WorkRecorder_Client {
    public partial class CustomerWindow : Window {

        private readonly Work _work;

        public CustomerWindow(Work work) {
            InitializeComponent();
            ResetValidationLabales();

            if (work != null) {
                _work = work;

                FirstNameTextBox.Text = _work.FirstName;
                LastNameTextBox.Text = _work.LastName;
                CarBrandTextBox.Text = _work.CarBrand;
                CarTypeTextBox.Text = _work.CarType;
                LicensePlateTextBox.Text = _work.LicensePlate;
                DescriptionTextBox.Text = _work.Description;

                CreateButton.Visibility = Visibility.Collapsed;
                UpdateButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;
            } else {
                _work = new Work();

                CreateButton.Visibility = Visibility.Visible;
                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }

        }

        public void CreateButtonClick(object sender, RoutedEventArgs e) {
            ResetValidationLabales();
            if (ValidateInput()) {
                _work.FirstName = FirstNameTextBox.Text;
                _work.LastName = LastNameTextBox.Text;
                _work.CarBrand = CarBrandTextBox.Text;
                _work.CarType = CarTypeTextBox.Text;
                _work.LicensePlate = LicensePlateTextBox.Text;
                _work.Description = DescriptionTextBox.Text;

                //WorkDataProvider.CreateWork(_work);

                DialogResult = true;
                Close();
            }

        }
        public void UpdateButtonClick(object sender, RoutedEventArgs e) {
            ResetValidationLabales();
            if (ValidateInput()) {
                _work.FirstName = FirstNameTextBox.Text;
                _work.LastName = LastNameTextBox.Text;
                _work.CarBrand = CarBrandTextBox.Text;
                _work.CarType = CarTypeTextBox.Text;
                _work.LicensePlate = LicensePlateTextBox.Text;
                _work.Description = DescriptionTextBox.Text;

                //WorkDataProvider.UpdateWOrk(_work);

                DialogResult = true;
                Close();
            }
        }
        public void DeleteButtonClick(object sender, RoutedEventArgs e) {
            if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes) {
                // WorkDataProvider.DeleteWork(_work.Id);

                DialogResult = true;
                Close();
            }

        }

        private bool ValidateInput() {
            try {
                CustomerValidation.ValidateFirstName(FirstNameTextBox.Text);
                CustomerValidation.ValidateLastName(LastNameTextBox.Text);
                CustomerValidation.ValidateBrandName(CarBrandTextBox.Text);
                CustomerValidation.ValidateCarType(CarTypeTextBox.Text);
                CustomerValidation.ValidateLicensePlateName(LicensePlateTextBox.Text);
                return true;
            } catch (InvalidFirstNameException e) {
                ShowErrorMessage(FirstNameErrLabel, e.Message);
            } catch (InvalidLastNameException e) {
                ShowErrorMessage(LastNameErrLabel, e.Message);
            } catch (InvalidBrandNameException e) {
                ShowErrorMessage(CarBrandErrLabel, e.Message);
            } catch (InvalidCarTypeException e) {
                ShowErrorMessage(CarTypeErrLabel, e.Message);
            } catch (InvalidLicensePlateException e) {
                ShowErrorMessage(LicensePlateErrLabel, e.Message);
            }
            return false;
        }


        private void ResetValidationLabales() {
            FirstNameErrLabel.Content = "";
            LastNameErrLabel.Content = "";
            CarBrandErrLabel.Content = "";
            CarTypeErrLabel.Content = "";
            LicensePlateErrLabel.Content = "";
            DescriptionErrLabel.Content = "";
        }

        private void ResetLabelContent(Label label) {
            label.Content = "";
        }

        private void ShowErrorMessage(Label label, String message) {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }

        private void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
            try {
                CustomerValidation.ValidateFirstName(textBox.Text);
                ResetLabelContent(FirstNameErrLabel);
            } catch (InvalidFirstNameException ex) {
                ShowErrorMessage(FirstNameErrLabel, ex.Message);
            }
        }
        private void LastNameTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
            try {
                CustomerValidation.ValidateLastName(textBox.Text);
                ResetLabelContent(LastNameErrLabel);
            } catch (InvalidLastNameException ex) {
                ShowErrorMessage(LastNameErrLabel, ex.Message);
            }
        }
        
        private void CarBrandNameTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
            try {
                CustomerValidation.ValidateBrandName(textBox.Text);
                ResetLabelContent(CarBrandErrLabel);
            } catch (InvalidBrandNameException ex) {
                ShowErrorMessage(CarBrandErrLabel, ex.Message);
            }
        }
        private void CarTypeTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
            try {
                CustomerValidation.ValidateCarType(textBox.Text);
                ResetLabelContent(CarTypeErrLabel);
            } catch (InvalidCarTypeException ex) {
                ShowErrorMessage(CarTypeErrLabel, ex.Message);
            }
        }
        private void LicensePlateTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
            try {
                CustomerValidation.ValidateLicensePlateName(textBox.Text);
                ResetLabelContent(LicensePlateErrLabel);
            } catch (InvalidLicensePlateException ex) {
                ShowErrorMessage(LicensePlateErrLabel, ex.Message);
            }
        }
    }
}
