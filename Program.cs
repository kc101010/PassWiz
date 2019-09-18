﻿
using System;
using System.Collections.Generic;
using System.Text;


namespace PassWizExpandedEdition
{
    class Program
    {


        static void Main(string[] args)


        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "PassWiz 1.0 (DEVELOPMENT TEST BUILD - SEP 2019)";
            Console.Write("Welcome to the PassWiz Utility!");
            MenuOption();
        }


        static void MenuOption()
        {
            Console.Write("\n");
            string user_choice;
            user_choice = Console.ReadLine();
            string[] endPasswordArray = new string[] { "password" };

            switch (user_choice)
            {
               

                case "-G":
                    GeneratePassword(endPasswordArray);
                    break;


                case "-V":
                    ValidatePassword();
                    break;


                case "HELP":
                    PrintHelpMessage();
                    break;

                case "help":
                    PrintHelpMessage();
                    break;

            
                default:
                    InvalidMessage();
                    break;

            }

        }

        



        private static void GeneratePassword(string[] endPasswordArray)  {

            Console.WriteLine("### PASSWORD GENERATOR ###");
            int length;
            int amount;

            do
            {
                Console.Write("Please enter the amount of passwords you would like: ");
                amount = Convert.ToInt32(Console.ReadLine());

            } while (amount < 1 || amount > 200);
                    
                

            do {
                if (amount > 1)
                {
                    Console.Write("Please enter the length of your passwords: ");
                    length = Convert.ToInt32(Console.ReadLine());


                }
                else
                {

                    Console.Write("Please enter the length of your password: ");
                    length = Convert.ToInt32(Console.ReadLine());


                }
            } while (length < 1 || length > 20);


            
            endPasswordArray = new string [amount];
            int DisplayCounter = 0;

            for (int n = 0; n < amount; n++)
            {
                PasswordBuilder(length, amount, endPasswordArray, n);
                ++DisplayCounter;

                
                Console.Write("\n PASSWORD " + DisplayCounter +  " :: "   + endPasswordArray[n]);

            }



            MenuOption();


        }


        private static void PasswordBuilder(int length, int amount, string[] endPasswordArray, int n)
        {
            char[] passwordResources = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '!', '?', '#', '&', '%', '£', '$', '*' };


            var PasswordBuilder = new StringBuilder();
            Random randNum = new Random();

            const int min = 0;
            const int max = 69;

            int i;

            for (int z = 0; z < amount; z++)
            {

                string EndPassword = "";
                int passwdPat;
                PasswordBuilder.Clear();

                for (i = 0; i < length; i++)
                {


                    passwdPat = 0;
                    passwdPat = randNum.Next(min, max);
                    PasswordBuilder.Append(passwordResources[passwdPat]);
                    


                }

                EndPassword = PasswordBuilder.ToString();


                endPasswordArray[z] = EndPassword;


            }








        }


        private static void PrintHelpMessage()
        {
            Console.Write("\n -G = \t Generate Password");
            Console.Write("\n -V = \t Validate your own Password");
            Console.Write("\n Commands are case sensitive - If it contains a capital it must always use a capital");
            Console.Write("\n The only exception to case sensitivity is the HELP command ");
            Console.Write("\n The program will always wait for an input after you use a tool \n");
            MenuOption();

        }


        private static void ValidatePassword()
        {
            Console.Write("\n ### PASSWORD VALIDATOR ### \n");
            Console.Write("\n Enter password to validate: \n\n");

            string password_For_validation;

            password_For_validation = Console.ReadLine();


            char[] valPasswordSubstring = password_For_validation.ToCharArray();
          

            bool isvalid_Password = false;
          
            //bool isvalid_SpeChars = false;

            var passwordComparison = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '#', '!', '?', '%' , '$', '£', '&', '*', '(', ')' };
            

            int CharCounter = 0;

            //$V91O9z?#e

            foreach (char element in passwordComparison)
            {
                //Console.Write(passwordComparison);
                for (int f = 1; f < password_For_validation.Length; f++)
                {
                    //Console.Write(f);
                    if (valPasswordSubstring[f].Equals(passwordComparison[f]) || passwordComparison.Equals(valPasswordSubstring[f])) 
                    {
                        //Console.WriteLine("HELLO");
                        // isvalid_SpeChars = true;
                        CharCounter++;
                    }
                }


            }

            Console.Write("\n\t### PASSWORD VALIDATION RESULTS ###");
            Console.Write("\n\t" + password_For_validation + "::" + " Valid? : " + isvalid_Password + "\n");

            if (password_For_validation.Length >= 8 && CharCounter > 1) {
                isvalid_Password = true;
            }
            else if (password_For_validation.Length < 8) {
                isvalid_Password = false;
                Console.Write("\n\tPASSWORD TOO SHORT");
                
            }
            else if (CharCounter < 1) {
                isvalid_Password = false;
                Console.Write("\n\tNOT ENOUGH SPECIAL CHARACTERS/NUMBERS");
            }
            else{
                isvalid_Password = false;
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

  

    

