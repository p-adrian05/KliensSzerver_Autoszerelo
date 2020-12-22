using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkRecorder_Client.Validation;

namespace WorkRecorder_Client.Validation.Tests {
    [TestClass()]
    public class CustomerValidationTests
    {
        [TestMethod()]
        public void ValidateFirstNameTestThrowInvalidFirstNameException() {
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName(""));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName(" "));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("name Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("NaMe"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("NaMe Na"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("NamME Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name2 Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name2 Name F"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name NameD"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name "));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name@ "));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Namenamenamenmanamenamenamenmaa"));
          
        }
        [TestMethod()]
        public void ValidateFirstNameTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Name"));
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Name Name"));
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Name N"));
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Namenamenamenmanamenamenamenma"));
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Namenamenamenmanamenamenamen"));
        }

        [TestMethod()]
        public void ValidateLastNameTestThrowInvalidLastNameException() {
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName(""));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName(" "));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("name"));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("name Name"));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("Name "));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("NameD "));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("Name3 "));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("Name$ "));
            Assert.ThrowsException<InvalidLastNameException>(() => CustomerValidation.ValidateLastName("Namenamenamenmanamenamenamenmaa"));
        }
        [TestMethod()]
        public void ValidateLastNameTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateLastName("Name"));
            Assert.IsTrue(CustomerValidation.ValidateLastName("Namenamenamenmanamenamenamenma"));
            Assert.IsTrue(CustomerValidation.ValidateLastName("Namenamenamenmanamenamenamenm"));
        }
        [TestMethod()]
        public void ValidateBrandNameTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateBrandName("Toyota"));
            Assert.IsTrue(CustomerValidation.ValidateBrandName("Ford"));
            Assert.IsTrue(CustomerValidation.ValidateBrandName("Mercedes"));
            Assert.IsTrue(CustomerValidation.ValidateBrandName("Ferrari"));
            Assert.IsTrue(CustomerValidation.ValidateBrandName("Testname"));
            Assert.IsTrue(CustomerValidation.ValidateBrandName("Test"));
        }


        [TestMethod()]
        public void ValidateBrandNameTestThrowInvalidBrandNameException()
        {
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName(""));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName(" "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("bran d "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("brand Name "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("Branda   "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("Brand Name D "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("Name3** "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("//Name$ "));
            Assert.ThrowsException<InvalidBrandNameException>(() => CustomerValidation.ValidateBrandName("Namesdgvsdfgsdfghenmsadasdasdasd"));
        }

        [TestMethod()]
        public void ValidateLicensePlateNameTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("WWW111"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("KLK231"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("QWE231"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("FRD231"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("SDD123"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("SDW123"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("SDC431"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("WUW111"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("ULK231"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("QWU231"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("FRF231"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("SSD123"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("SWW123"));
            Assert.IsTrue(CustomerValidation.ValidateLicensePlateName("SDE431"));
        }

        [TestMethod()]
        public void ValidateLicensePlateNameTestThrowInvalidLicensePlateException()
        {
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName(""));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName(" "));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SDD1111"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("1111AAA"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SDAD111"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SSA1132"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("11111"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SSSSS"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SD11AS11"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SSA1132"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("1"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("SSSSSDFS"));
            Assert.ThrowsException<InvalidLicensePlateException>(() => CustomerValidation.ValidateLicensePlateName("!+%+"));
        }

        [TestMethod()]
        public void ValidateCarTypeTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateCarType("Fiesta S5"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Mondeo"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Falcon"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Mustang"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("EcoSport"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Escape"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Everest"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Escape 5"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Everest 44"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Esc 5"));
            Assert.IsTrue(CustomerValidation.ValidateCarType("Ev 14"));
        }

        [TestMethod()]
        public void ValidateCarTypeTestInvalidCarTypeException()
        {
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType(""));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType(" "));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("SDD1111%"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("111A--AA"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("SDA!!D111"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType(" SS                         A32 "));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType(" Ty..pe 2 "));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("Bog 4*8 48"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("_wse_()we_we"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("_wse_we_we.9"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("_wse7we._we"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("we?"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("|w|"));
            Assert.ThrowsException<InvalidCarTypeException>(() => CustomerValidation.ValidateCarType("asd@@as"));
        }
    }
}