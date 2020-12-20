using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WorkRecorder_Client.Validation {
    public class CustomerValidation {
        private const int firstNameLength = 30;
        private const int lastNameLength = 30;
        private const int brandLength = 20;
        private const int carTypeLength = 20;

        public static bool ValidateFirstName(String name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new InvalidFirstNameException("FirstName should not be empty.");
            }else if (name.Length > firstNameLength) {
                throw new InvalidFirstNameException($"FirstName length is max {firstNameLength} characters");
            }
            else if (!Regex.IsMatch(name, @"^([A-Z][a-z]*)?(\s{0,1}[A-Z][a-z]*)$")) {
                throw new InvalidFirstNameException("Invalid first name");
            }
            return true;
        }
        public static bool ValidateLastName(String name) {
            if (string.IsNullOrWhiteSpace(name)) {
                throw new InvalidLastNameException("Last Name should not be empty.");
            } else if (name.Length > lastNameLength) {
                throw new InvalidLastNameException($"LastName length is max {lastNameLength} characters");
            } else if (!Regex.IsMatch(name, @"^[A-Z][a-z]*$")) {
                throw new InvalidLastNameException("Invalid last name");
            }
            return true;
        }
        public static bool ValidateBrandName(String brandName) {
            if (string.IsNullOrWhiteSpace(brandName)) {
                throw new InvalidBrandNameException("Brand name should not be empty.");
            } else if (brandName.Length > brandLength) {
                throw new InvalidBrandNameException($"Brand length max {brandLength} characters");
            } else if (!Regex.IsMatch(brandName, @"^[A-Z][a-z]*$")) {
                throw new InvalidBrandNameException("Invalid brand");
            }
            return true;
        }
        public static bool ValidateLicensePlateName(String licensePlate) {
            if (string.IsNullOrWhiteSpace(licensePlate)) {
                throw new InvalidLicensePlateException("License plate should not be empty.");
            } else if (!Regex.IsMatch(licensePlate, @"^[A-Z0-9]{6}$")) {
                throw new InvalidLicensePlateException("Only capital letters and numbers and max 6 character. ");
            }
            return true;
        }
        public static bool ValidateCarType(String carTypeName) {
            if (string.IsNullOrWhiteSpace(carTypeName)) {
                throw new InvalidCarTypeException("Car type should not be empty.");
            } else if (carTypeName.Length > carTypeLength) {
                throw new InvalidCarTypeException($"Car type length max {carTypeLength} characters");
            } else if (!Regex.IsMatch(carTypeName, @"^(\w*(\s*))*$")) {
                throw new InvalidCarTypeException("No special characters allowed");
            }
            return true;
        }
    }
}
