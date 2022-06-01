using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
using System;

namespace UserRegistrationTesting
{
    [TestClass]
    public class UserValidation
    {
        Validation validation;
        UserRegistrationReflector userRegistrationReflector;
        [TestInitialize]
        public void SetUp()
        {
            // common Arrange
            validation = new Validation();
            userRegistrationReflector = new UserRegistrationReflector();
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple first names
        [DataRow("Madhavee", "Input is valid")]
        [DataRow("Ab", "Input is not valid")]
        [DataRow("madhavee", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenFirstNameValidation(string firstName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                validation = new Validation(firstName);
                string actual = validation.FirstNameValidation();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple last names
        [DataRow("Kadivar", "Input is valid")]
        [DataRow("Ab", "Input is not valid")]
        [DataRow("kadivar", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenLastNameValidation(string lastName, string expected) // Testing for Lastname Validation
        {
            try
            {
                //Act
                string actual = validation.LastNameValidation(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple email samples
        [DataRow("abc123@.com", "Input is not valid")]
        [DataRow("abc@abc@gmail.com", "Input is not valid")]
        [DataRow("abc+100@gmail.com", "Input is valid")]
        [DataRow("abc@1.com", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenEmailValidation(string email, string expected) // Testing for Lastname Validation
        {
            try
            {
                //Act
                string actual = validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple mobile numbers
        [DataRow("91 9652545874", "Input is valid")]
        [DataRow("919652545874", "Input is not valid")]
        [DataRow("9144 9652545874", "Input is not valid")]
        [DataRow("91 1652545874", "Input is not valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenMobileNumberValidation(string mobileNumber, string expected) // Testing for mobile number Validation
        {
            try
            {
                //Act
                string actual = validation.MobileNumberValidation(mobileNumber);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", "Input is valid")]
        [DataRow("ADF@#$%JVGB", "Input is valid")]
        [DataRow("FVGdf", "Input is not valid")]
        [DataRow("8745fgvhA", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule1Validation(string password, string expected) // Testing for password rule 1 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule1Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfghnjvbn", "Input is not valid")]
        [DataRow("A5sdf@#34", "Input is valid")]
        [DataRow("FVGdf", "Input is not valid")]
        [DataRow("wsdfgADFG65@3", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule2Validation(string password, string expected) // Testing for password rule 2 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule2Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", "Input is not valid")]
        [DataRow("A5sdf@#df", "Input is valid")]
        [DataRow("F5G@f", "Input is not valid")]
        [DataRow("8465ADFG", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule3Validation(string password, string expected) // Testing for password rule 3 Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule3Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple password samples
        [DataRow("dfgDnjvbn", "Input is not valid")]
        [DataRow("A5sdf@df", "Input is valid")]
        [DataRow("F5G@f", "Input is not valid")]
        [DataRow("85ADcv*gj5", "Input is valid")]
        [DataRow("*&&dfgADDd845", "Input is not valid")]
        [DataRow("885@dfvvvb", "Input is not valid")]
        [DataRow("AAaa#8ghbb", "Input is valid")]
        [DataRow("", "Input should not be empty")]
        [DataRow(null, "Input should not be null")]
        public void GivenPasswordRule4Validation(string password, string expected) // Testing for password rule 4 along with all Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordRule4Validation(password);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestCategory("Exception")]
        [TestMethod]
        //Checking for multiple email samples that are valid
        [DataRow("abc@gmail.com", "Input is valid")]
        [DataRow("abc-100@yahoo.com", "Input is valid")]
        [DataRow("abc.100@yahoo.com", "Input is valid")]
        [DataRow("abc@1.com", "Input is valid")]
        [DataRow("abc111@yahoo.com.au", "Input is valid")]
        [DataRow("abc-100@yahoo.com.au", "Input is valid")]
        [DataRow("abc@gmail.com.com", "Input is valid")]
        [DataRow("abc+100@yahoo.com", "Input is valid")]
        //Checking for multiple email samples that are Invalid
        [DataRow("abc", "Input is not valid")]
        [DataRow("abc@.com.my", "Input is not valid")]
        [DataRow("abc123@gmail.a", "Input is not valid")]
        [DataRow("abc123@.com", "Input is not valid")]
        [DataRow("abc@.com.com", "Input is not valid")]
        [DataRow(".abc@abc.com", "Input is not valid")]
        [DataRow("abc()*@gmail.com", "Input is not valid")]
        [DataRow("abc@%*.com", "Input is not valid")]
        [DataRow("abc..2002@gmail.com", "Input is not valid")]
        [DataRow("abc.@gmail.com", "Input is not valid")]
        [DataRow("abc@abc@gmail.com", "Input is not valid")]
        [DataRow("abc@gmail.com.1a", "Input is not valid")]
        [DataRow("abc@gmail.com.aa.au", "Input is not valid")]
        public void GivenEmailSamplesValidation(string email, string expected) // Testing for email samples Validation
        {
            try
            {
                //Act
                string actual = validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// Create a object of Validation class using reflection
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenClassNameShoulReturnObject()
        {
            object expected = new Validation();
            object actual = userRegistrationReflector.CreateValidationObject("UserRegistrationProblem.Validation", "Validation");
            expected.Equals(actual);
        }
        /// <summary>
        /// Given Class Name When Improper Should Throw InvalidException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidClassThrowException()
        {
            try
            {
                object expected = new Validation();
                object actual = userRegistrationReflector.CreateValidationObject("UserRegistrationProblem.valid", "valid");
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        /// <summary>
        /// Given Validation Class Name Should Return Validation object with parameter
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenClassNameShoulReturnParameterizedObject()
        {
            string input = "Madhavee";
            object expected = new Validation(input);
            object actual = userRegistrationReflector.CreateValidationParameterizedObject("UserRegistrationProblem.Validation", "Validation", input);
            expected.Equals(actual);
        }

        /// <summary>
        /// Given Class Name When Improper Should Throw InvalidException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidClassNameWithMessageThrowException()
        {
            try
            {
                string input = "Madhavee";
                object expected = new Validation(input);
                object actual = userRegistrationReflector.CreateValidationParameterizedObject("UserRegistrationProblem.valid", "valid", input);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        /// <summary>
        /// Given FirstName validation Using Reflection When Proper Should Return Input is valid invoking a method
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenMethodNameWithInputReturnsValidity()
        {
            string input = "Madhavee";
            string expected = "Input is valid";
            string actual = "";
            try
            {
                actual = userRegistrationReflector.InvokeMethod(input, "FirstNameValidation");
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("Method not found", ex.Message);
            }
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Given Invalid method name should throw the exception
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidMethodNameWithInputThrowException()
        {
            string input = "Madhavee";
            string expected = "Input is valid";
            string actual = "";
            try
            {
                actual = userRegistrationReflector.InvokeMethod(input, "FirstName");
                Assert.AreEqual(expected, actual);
            }
            catch (InvalidException ex)
            {
                Assert.AreEqual("Method not found", ex.Message);
            }
        }
    }
}
