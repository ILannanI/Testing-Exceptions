using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserValidatorTests
{
    [TestClass]
    public class UserValidatorTest
    {
        private UserValidator userValidator;

        [TestInitialize]
        public void Setup()
        {
            userValidator = new UserValidator();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidUsernameException))]
        public void Test_InvalidUsername_ShouldThrowInvalidUsernameException()
        {
            string invalidUsername = "usr";  
            string validPassword = "ValidPass1";

            userValidator.ValidateCredentials(invalidUsername, validPassword);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPasswordException))]
        public void Test_InvalidPassword_ShouldThrowInvalidPasswordException()
        {
            // Arrange
            string validUsername = "ValidUser";
            string invalidPassword = "short"; 

            // Act
            userValidator.ValidateCredentials(validUsername, invalidPassword);

            // Assert is handled by the ExpectedException attribute
        }

        [TestMethod]
        public void Test_ValidCredentials_ShouldNotThrowAnyException()
        {
            // Arrange
            string validUsername = "ValidUser";
            string validPassword = "ValidPassword1";

            try
            {
                userValidator.ValidateCredentials(validUsername, validPassword);
            }
            catch (Exception)
            {
                Assert.Fail("Exception should not be thrown for valid credentials.");
            }
        }
    }
}

