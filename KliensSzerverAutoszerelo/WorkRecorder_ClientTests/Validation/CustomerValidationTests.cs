using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkRecorder_Client.Validation;

namespace WorkRecorder_Client.Validation.Tests {
    [TestClass()]
    public class CustomerValidationTests {
        [TestMethod()]
        public void validateFirstNameTestThrowInvalidFirstNameException() {
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName(""));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName(" "));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("name Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("Name name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("NamME Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("Name2 Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("Name2 Name F"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("Name NameD"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.validateFirstName("Name "));
        }
        [TestMethod()]
        public void validateFirstNameTest() {
            Assert.IsTrue(CustomerValidation.validateFirstName("Name"));
            Assert.IsTrue(CustomerValidation.validateFirstName("Name Name"));
            Assert.IsTrue(CustomerValidation.validateFirstName("Name N"));
            Assert.IsTrue(CustomerValidation.validateFirstName("NameN"));
        }

        [TestMethod()]
        public void validateLastNameTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateBrandNameTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateLicensePlateNameTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void validateCarTypeTest() {
            Assert.Fail();
        }
    }
}