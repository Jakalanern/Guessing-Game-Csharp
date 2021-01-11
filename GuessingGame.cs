using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool responsebool = true;
            bool responsebool2 = true;
            bool responsebool3 = true;
            bool responsebool4 = true;
            bool responsebool5 = true;
            bool Responsebool = true;
            bool Responsebool2 = true;
            bool Responsebool3 = true;
            bool Responsebool4 = true;
            bool Responsebool5 = true;
            string response = "Incorrect! ";
            string response2 = "That's not right... ";
            string response3 = "So close yet so far... ";
            string response4 = "You'll get it eventually. ";
            string response5 = "Come on.. I know you can guess this. ";
            string secret = "turtle";
            string secretcap = "Turtle";
            int whilecounter = 2;            
            string hint1 = "Hint 1: It's a living thing.";
            string hint2 = "Hint 2: It can be found on land, in streams, or in the ocean.";
            string hint3 = "Hint 3: It's carries a shield.";
            bool hintgiven1 = true;
            bool hintgiven2 = true;
            bool hintgiven3 = true;
            bool intro = true;
            string guessagain = "Guess again: ";

            while (true)
            {
                if (intro == true)
                {
                    Console.WriteLine("Guess the thing I am thinking of! I'll give you some hints soon. \n");
                    intro = false;
                }

                else
                { 
;                Console.WriteLine(guessagain);
                }

                string input = Console.ReadLine();

               
                if (input != secret && input != secretcap) 
                {
                                                           
                        if (responsebool == true && hintgiven3 == true)
                        {
                            Console.WriteLine(response + whilecounter + " more tries until hint.");
                            responsebool = false;
                        }
                        else if(responsebool2 == true && hintgiven3 == true)
                        {
                            Console.WriteLine(response2 + whilecounter + " more try until hint.");
                            responsebool2 = false;
                        }
                        else if (responsebool3 == true && hintgiven3 == true)
                        {
                            Console.WriteLine(response3 + whilecounter + " more tries until hint.");
                            responsebool3 = false;
                        }
                        else if (responsebool4 == true && hintgiven3 == true)
                        {
                            Console.WriteLine(response4 + whilecounter + " more tries until hint.");
                            responsebool4 = false;
                        }
                        else if (responsebool5 == true && hintgiven3 == true)
                        {
                            Console.WriteLine(response5 + whilecounter + " more try until hint.");
                            responsebool5 = false;
                        }                      
                        else
                        {
                            responsebool = true;
                            responsebool2 = true;
                            responsebool3 = true;
                            responsebool4 = true;
                            responsebool5 = true;
                        }
                    
                        if (Responsebool == true && hintgiven3 == false)
                        {
                            Console.WriteLine(response + " No more hints!");
                            Responsebool = false;                               
                        }
                        else if (Responsebool2 == true && hintgiven3 == false)
                        {
                            Console.WriteLine(response2 + " No more hints!");
                            Responsebool2 = false;
                        }
                        else if (Responsebool3 == true && hintgiven3 == false)
                        {
                            Console.WriteLine(response3 + " No more hints!");
                            Responsebool3 = false;
                        }
                        else if (Responsebool4 == true && hintgiven3 == false)
                        {
                            Console.WriteLine(response4 + " No more hints!");
                            Responsebool4 = false;
                        }
                        else if (Responsebool5 == true && hintgiven3 == false)
                        {
                            Console.WriteLine(response5 + " No more hints!");
                            Responsebool5 = false;
                        }
                        else
                        {

                            Responsebool = true;
                            Responsebool2 = true;
                            Responsebool3 = true;
                            Responsebool4 = true;
                            Responsebool5 = true;
                        }
                           
                    
                    whilecounter--;
                
                
                    if (whilecounter == -1 && hintgiven1 == true)
                        {                        
                            Console.WriteLine(hint1);
                            Console.WriteLine("");
                            whilecounter = 2;
                            hintgiven1 = false;
                        }

                    else if (hintgiven1 == false && whilecounter == -1 && hintgiven2 == true)
                    {
                        Console.WriteLine(hint2);
                        Console.WriteLine("");
                        whilecounter = 2;
                        hintgiven2 = false;
                    }

                    else if (hintgiven2 == false && whilecounter == -1 && hintgiven3 == true)
                    {
                        Console.WriteLine(hint3);                       
                        Console.WriteLine("");
                        whilecounter = 0;
                        hintgiven3 = false;
                    }
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations!!! I knew you could do it!! You've guessed the word!");
                    Console.WriteLine("");
                    Console.WriteLine("Press ENTER and this game will now close. ");
                    break;
                }
            }
        }
    }
}
