using System;
using System.Text;
using System.Threading;



/*
                       
    
    
                        ####        PASSWORD GENERATOR CLASS            ###
                        
                
     
     
 */

namespace PassWiz
{

    public class P_Generator
    {
        public static int length;               //declare length for use in below method



        public static string passwordBuilder(int length)
        {
                                
       
            Thread.Sleep(30);                       //pause to allow randomisation to properly function
            //possible characters available for use by method
            char[] pass_res = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '!', '?', '#', '&', '%', '£', '$', '*' };
           
            var p_Builder = new StringBuilder();    //create a string builder function to make up password
            Random ranNum = new Random();           //create a random function to select password chars

            const int min = 0, max = 69;            //declare max and min for possible chars chosen from array
            int i;                                  //value for loop iteration
            string EndPassword;                     //Stores final password
            
            

             


             int passwdPat;                         //character value from array
             p_Builder.Clear();                     //clear string builder to avoid duplicate passwords

                for (i = 0; i < length; i++)
                {
                    passwdPat = 0;                  //reset value so character does not automatically repeat
                    passwdPat = ranNum.Next(min, max); //generate random number to select password character
                    p_Builder.Append(pass_res[passwdPat]);//add character to password builder

                    
                }   

                EndPassword = p_Builder.ToString(); //convert password builder to string and assign it

            
            return EndPassword;                    //return end password 


        }

    }
}

