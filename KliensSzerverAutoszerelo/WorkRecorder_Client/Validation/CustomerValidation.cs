using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WorkRecorder_Client.Validation {
    public class CustomerValidation {
        public static bool validateFirstName(String name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new InvalidFirstNameException("FirstName should not be empty.");
            } else if (!Regex.IsMatch(name, @"^([A-Z][a-z]*)?(\s{0,1}[A-Z][a-z]*)$")) {
                throw new InvalidFirstNameException("Invalid first name");
            }
            return true;
        }
        public static bool validateLastName(String name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new InvalidLastNameException("Last Name should not be empty.");
            } else if (!Regex.IsMatch(name, @"^[A-Z][a-z]*$")) {
                throw new InvalidLastNameException("Invalid last name");
            }
            return true;
        }
        public static bool validateBrandName(String brandName) {
            if (string.IsNullOrWhiteSpace(brandName)) {
                throw new InvalidBrandNameException("Brand name should not be empty.");
            } else if (!Regex.IsMatch(brandName, @"^[A-Z][a-z]*$")) {
                throw new InvalidBrandNameException("Invalid brand");
            }
            return true;
        }
        public static bool validateLicensePlateName(String licensePlate) {
            if (string.IsNullOrWhiteSpace(licensePlate)) {
                throw new InvalidLicensePlateException("License plate should not be empty.");
            } else if (!Regex.IsMatch(licensePlate, @"^[A-Z0-9]{6}$")) {
                throw new InvalidLicensePlateException("Only capital letters and numbers and max 6 character. ");
            }
            return true;
        }
        public static bool validateCarType(String carTypeName) {
            if (string.IsNullOrWhiteSpace(carTypeName)) {
                throw new InvalidCarTypeException("Car type should not be empty.");
            } else if (!Regex.IsMatch(carTypeName, @"^(\w*(\s*))*$")) {
                throw new InvalidCarTypeException("No special characters allowed");
            }
            return true;
        }
    }
}
