using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkRecorder_Client.Validation;

namespace WorkRecorder_Client.Validation.Tests {
    [TestClass()]
    public class CustomerValidationTests {
        [TestMethod()]
        public void ValidateFirstNameTestThrowInvalidFirstNameException() {
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName(""));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName(" "));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("name Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("NamME Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name2 Name"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name2 Name F"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name NameD"));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name "));
            Assert.ThrowsException<InvalidFirstNameException>(() => CustomerValidation.ValidateFirstName("Name@ "));
        }
        [TestMethod()]
        public void ValidateFirstNameTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Name"));
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Name Name"));
            Assert.IsTrue(CustomerValidation.ValidateFirstName("Name N"));
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
        }
        [TestMethod()]
        public void ValidateLastNameTestExpectedTrue() {
            Assert.IsTrue(CustomerValidation.ValidateLastName("Name"));
        }
        [TestMethod()]
        public void ValidateBrandNameTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidateLicensePlateNameTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void ValidateCarTypeTest() {
            Assert.Fail();
        }
    }
}