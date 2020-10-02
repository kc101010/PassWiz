
using System.Linq;

/*
 
     
                        ####          PASSWORD VALIDATOR CLASS           ####    
     
     
 */

namespace PassWiz
{
    class pass_val
    {
    }

    public class P_Val 
    {

        //Object to store password input from interface 
        public static string PasswordToValidate;

        public static string validatePassword() {
            //declare arrays for comparisons
           
            char[] passwordComparison_spechar = { '@', '#', '!', '?', '£', '$', '%', '^', '*', '(', ')', ':', ';' };

            //booleans to denote what requirements have been met
            bool Contains_SpeChars = false;                                     //          REQUIREMENTS FOR A VALID PASSWORD (ACCORDING TO THIS PROGRAM)
            bool Contains_Numbers = false;                                      //  Must contain (at least): 1 number, 1 special character, 1 capital letter
            bool Contains_CapitalLetter = false;                                //  Must have a length of 8 or more
            bool validLength = false;                                           //

            

            //INCLUDE LINE TO RECIEVE & ASSIGN entered password
           char[] passwordValues = PasswordToValidate.ToCharArray();

            //use LINQ to validate if password contains capital letters and numbers
            if (PasswordToValidate.Any(char.IsUpper)) {
                Contains_CapitalLetter = true;
            } 
            if (PasswordToValidate.Any(char.IsDigit)) {
                Contains_Numbers = true;
            }

            if (passwordValues.Length > 8) {
                validLength = true;
            }

            //SPECIAL CHARACTER VALIDATION
            for (int i = 0; i < passwordValues.Length; i++) {   //iterate for each character in the substring
                char temp = passwordValues[i];  //assign the current character to a temporary variable to prevent data access errors

                for (int a = 0; a < passwordComparison_spechar.Length; a++) {   //iterate for each character in the comparison array
                    if (temp == passwordComparison_spechar[a]) { Contains_SpeChars = true; }    //if there is a matching character then password contains a special character
                }
                
            }

            //Declare message to be returned 
            string resultMessage = "";


            //Assigns result message based on validation results
            if (Contains_SpeChars && Contains_Numbers && Contains_CapitalLetter && validLength == true)
            {
                resultMessage = "Password Valid";
            }
            else if (validLength == false)
            {
                resultMessage = "Invalid length";
            }
            else if (Contains_SpeChars == false)
            {
                resultMessage = "No special characters found";
            }
            else if (Contains_Numbers == false)
            {
                resultMessage = "No numbers found";
            }
            else if (Contains_CapitalLetter == false)
            {
                resultMessage = "No captial letter found";
            }
            else 
            {
                resultMessage = "Invalid Password - No results";
            }



            //return the process result
            return resultMessage;
        }



    }

}

/*
 
     
     
     
         foreach (char element in passwordValues)
            {
                foreach (char Velement in passwordComparison)
                {
                    if (passwordValues[element] == passwordComparison[element])
                    {
                        counter++;
                    }
                }
            }

            if (counter > 2)
            {
                valid_SpeChars = true;

            }

            if (passwordToValidate.Length > 8 && valid_SpeChars == true)
            {
                valid_Password = true;
                Console.Write("\n" + valid_Password);
            }
            else
            {

                Console.Write("\n" + valid_Password);
            }


            MenuOption();
        }


        static void InvalidMessage()
        {

            Console.Write("\n INVALID INPUT - PLEASE TRY AGAIN\n");
            MenuOption();

        }

     
        }

    }

     
     
     
     
*/
