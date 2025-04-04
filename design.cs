using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace PoEPart1
{
  
        public class design
        {
        //variable declaration and arrays
        public ArrayList outcome = new ArrayList();
        public ArrayList ignore_not_needed = new ArrayList();

        private string userName = string.Empty;
        private string userAsking = string.Empty;

        public design()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("           _**********************_                 ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("        Welcome to CyberSecurity ChatBot.        ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("            _**********************_                 ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Frank:- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please eneter your name...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("You:- ");
            Console.ResetColor();

            

            userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Frank:- ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello " + userName + ". My name is Frank Lamperd, how can I assist you today?");

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(userName + ":- ");
                Console.ResetColor();
                userAsking = Console.ReadLine();
                //if statement
                if (userAsking.ToLower() == "exit")
                {

                    Console.WriteLine("Goodbye "+userName+", I hope I managed to help you out... ");
                    System.Environment.Exit(0);
                }
                else {
                    answer(userAsking);
                }
            } while (userAsking!= "exit");
        }

                                            //SPLIT FILTER!!!
             private void answer(string asked)
        {
            //call both methods that stores the values
            store_outcome();
            store_ignore();

          

            //store all words the user enter by split function into one, one
            string[] store_words = asked.Split(' ');
            ArrayList final_words = new ArrayList();

            //for loop to display all stored from split
            for (int count = 0; count < store_words.Length; count++)
            {

                //ignore and add
                if (!ignore_not_needed.Contains(store_words[count]))
                {
                    //add the not ignored values or words
                    final_words.Add(store_words[count]);


                }//end of if statement 

            }//end of store_words array

            Boolean found = false;
            string message = string.Empty;


            //for loop to test final word array
            for (int index = 0; index < final_words.Count; index++)
            {
                //for loop for the replies arraylist
                for (int counting = 0; counting < outcome.Count; counting++)
                {
                    //check for final answer
                    if (outcome[counting].ToString().Contains(final_words[index].ToString()))
                    {
                        found = true;
                        message += outcome[counting] + "\n";

                    }//end of the if statement
                }//end of replies arrays loop

            }//end of for loop for final words array list

            //display
            if (found)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Frank:-" + message);
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please search something related to CyberSecurity!!!!!");
               
            }

        }//end constructor

        //store values for the question array
        public void store_outcome()
        {
            //add values
            outcome.Add("cybersecurity is the practice of protecting computer systems, networks, programs, and data from digital attacks, damage or unathorized access");
            outcome.Add("cybersecurity threats are:\n         *malware\n         *phishing\n         *ransomware\n         *denial-of-service\n");
            outcome.Add("the more complex your password the more protected it is.");
            outcome.Add("create strong, unique password that is at least 12 characters long.");
            outcome.Add("avoid using the same password for multiple accounts.");
            outcome.Add("avoid sharing your password with family, friends and colleagues");
            outcome.Add("don't enter your password on public wifi networks");
            outcome.Add("you know sql injection is on a high rate now.");
            outcome.Add("sql injection is an attack that attempts to subvert the relationship between a webpage and its supporting database");
            outcome.Add("safe browsing aims to protect users from cyber threats.");
            outcome.Add("safe browsing warns the user about potential dangerous websites and files before they are accessed");
            outcome.Add("safe browsing services scan for phising attempts, malware, and malicious downloads");
            outcome.Add("safe browsing services maintain a database of known malicious websites and files");
            outcome.Add("safe browsing notifies website owners if their sites are flagged as malicious, helping them address the issue.");
            outcome.Add("phishing is a type of social engineering attack where atackers, posing as legitimate entities, trick individuals into revealing sensitive information.");
            outcome.Add("spear phishing targets specific individuals or groups with personalized messages.");
            outcome.Add("they attack you using attacks like phishing and more");
            outcome.Add("email phishing attackers send emails that appear to be from legitimate companies, asking for personal information or directing users to fake websites.");
            outcome.Add("whaling is a phishing attack that targets high-profile individuals, such as CEO's, with higly targeted emails.");

        }//end store answer 

        //method to store ignore
        public void store_ignore()
        {
            //then store the values
            ignore_not_needed.Add("avoid");
            ignore_not_needed.Add("add");
            ignore_not_needed.Add("about");
            ignore_not_needed.Add("above");
            ignore_not_needed.Add("advice");
            ignore_not_needed.Add("attack");
            ignore_not_needed.Add("attacker");
            ignore_not_needed.Add("accessed");
            ignore_not_needed.Add("accounts");
            ignore_not_needed.Add("aims");
            ignore_not_needed.Add("about");
            ignore_not_needed.Add("attempts");
            ignore_not_needed.Add("address");
            ignore_not_needed.Add("between");
            ignore_not_needed.Add("because");
            ignore_not_needed.Add("before");
            ignore_not_needed.Add("below");
            ignore_not_needed.Add("reate");
            ignore_not_needed.Add("characters");
            ignore_not_needed.Add("collegues");
            ignore_not_needed.Add("CEO's");
            ignore_not_needed.Add("cyber");
            ignore_not_needed.Add("tell");
            ignore_not_needed.Add("me");
            ignore_not_needed.Add("more");
            ignore_not_needed.Add("malware");
            ignore_not_needed.Add("websites");
            ignore_not_needed.Add("targeted");
            ignore_not_needed.Add("highly");
            ignore_not_needed.Add("high-profile");
            ignore_not_needed.Add("emails");
            ignore_not_needed.Add("groups");
            ignore_not_needed.Add("using");
            ignore_not_needed.Add("notifies");
            ignore_not_needed.Add("individuals");
            ignore_not_needed.Add("send");
            ignore_not_needed.Add("legitimate");
            ignore_not_needed.Add("flagged");
            ignore_not_needed.Add("maintain");
            ignore_not_needed.Add("database");
            ignore_not_needed.Add("unique");
            ignore_not_needed.Add("users");
            ignore_not_needed.Add("cyber");
            ignore_not_needed.Add("threats");
            ignore_not_needed.Add("security");
        }


    }
        }

