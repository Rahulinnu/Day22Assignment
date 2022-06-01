using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Validation
    {
        public string input;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Validation()
        {
            Console.WriteLine("Default Constructor");
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="input"></param>
        public Validation(string input) 
        {
            this.input = input; // Assigning value to local variable
        }
        /// <summary>
        /// Creating a delegates to use regex in lambda expression and this Func returns bool value
        /// </summary>
        Func<string, bool> isNull = x => x == null;
        Func<string,string, bool> isPatternMatch = (x,y) => Regex.IsMatch(x,y);
        Func<string, bool> isEmpty = x => x == "";
        /// <summary>
        /// First Name Validation
        /// </summary>
        /// <returns></returns>
        public string FirstNameValidation() 
        {
            try
            {
                
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
                
                if (isNull(input))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when first name is null
                }
                if (isEmpty(input))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when first name is empty
                }
                if (isPatternMatch(input,pattern)) //If name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour first name \"{input}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when first name is not valid
                }
            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Last Name Validation
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public string LastNameValidation(string lName) 
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Regex for last name validation
                if (isNull(lName))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when last name is null
                }
                if (isEmpty(lName))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when last name is empty
                }
                if (isPatternMatch(lName, pattern)) //If last name entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour last name \"{lName}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when lastt name is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Email Name Validation
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string EmailValidation(string email) 
        {
            try
            {
                string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Regex for email validation
                if (isNull(email))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when email is null
                }
                if (isEmpty(email))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when email is empty
                }
                if (isPatternMatch(email, pattern)) //If email entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour email address \"{email}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when email is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Mobile Number Validation
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public string MobileNumberValidation(string mobileNumber) 
        {
            try
            {
                string pattern = "^[9][1][ ][6-9][0-9]{9}$"; // Regex for mobile number validation
                if (isNull(mobileNumber))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when mobile number is null
                }
                if (isEmpty(mobileNumber))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when mobile number is empty
                }
                if (isPatternMatch(mobileNumber, pattern)) //If mobile number entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour mobile number \"{mobileNumber}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when mobile number is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Password Rule 1 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string PasswordRule1Validation(string password) 
        {
            try
            {
                string patternForRule1 = "^[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password rule 1 validation
                if (isNull(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (isEmpty(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (isPatternMatch(password, patternForRule1)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Password Rule 2 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string PasswordRule2Validation(string password) 
        {
            try
            {
                string patternForRule2 = "^(?=.*[A-Z])[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password rule 2 validation
                if (isNull(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (isEmpty(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (isPatternMatch(password, patternForRule2)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Password Rule 3 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string PasswordRule3Validation(string password) 
        {
            try
            {
                string patternForRule3 = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z@#$%^&*!+=]{8,}$"; // Regex for password rule 3 validation
                if (isNull(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (isEmpty(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (isPatternMatch(password, patternForRule3)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }
        /// <summary>
        /// Password Rule 4 Validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public string PasswordRule4Validation(string password)
        {
            try
            {
                string patternForRule4 = @"^(?=.{8,}$)(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9]{0,}?[@~!#$%^&*+=\/-]{1}[a-zA-Z0-9]{0,}$"; // Regex for password rule 4 validation
                if (isNull(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.NULL_INPUT, "Input should not be null"); //throwing exception when password is null
                }
                if (isEmpty(password))
                {
                    throw new InvalidException(InvalidException.ExceptionType.EMPTY_INPUT, "Input should not be empty"); //throwing exception when password is empty
                }
                if (isPatternMatch(password, patternForRule4)) //If paasword entered by user is match with regex then it is valid otherwise not
                {
                    Console.WriteLine($"\nYour password \"{password}\" is valid");
                    return "Input is valid";
                }
                else
                {
                    throw new InvalidException(InvalidException.ExceptionType.INVALID_INPUT, "Input is not valid");//throwing exception when password is not valid
                }

            }
            catch (InvalidException ex) // If any exception throws then print exception message
            {
                Console.WriteLine("\n"+ex.Message);
                return ex.Message;
            }
        }

    }
}
