using KliensSzerverAutoszerelo_Common.Models;
using KliensSzerverAutoszerelo_Common.DataProviders;
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

namespace CarMechanic_Client
{
    /// <summary>
    /// Interaction logic for UpdateWorkStateWindow.xaml
    /// </summary>
    public partial class UpdateWorkStateWindow : Window
    {
        private  readonly Work _work;

        public UpdateWorkStateWindow(Work work)
        {
            InitializeComponent();

            if (work != null)
            {
                _work = work;

                FirstNameLabel.Content = _work.FirstName;
                LastNameLabel.Content = _work.LastName;
                CarBrandLabel.Content = _work.CarBrand;
                CarTypeLabel.Content = _work.CarType;
                LicensePlateLabel.Content = _work.LicensePlate;
                DescriptionLabel.Text = _work.Description;
                WorkStateComboBox.SelectedIndex = (int)_work.WorkState;

            }
            

        }

        private void UpdateButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                _work.WorkState = (WorkState)WorkStateComboBox.SelectedIndex;

                WorkDataProvider.UpdateWork(_work);
                DialogResult = true;
                Close();
            }
            catch (InvalidOperationException ex)
            {
                ShowErrorMessage(ErrorLabel, ex.Message);
            }

        }

        private void WorkStateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _work.WorkState = (WorkState) WorkStateComboBox.SelectedIndex;

        }

        private void ShowErrorMessage(Label label, String message)
        {
            label.Content = message;
            label.Foreground = Brushes.Red;
        }
    }
}
