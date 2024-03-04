using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizzard_Spoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //player variables
            int playerScore = 0;
            int enemyScore = 0;

            Random random = new Random();

            Console.WriteLine(" Welcome to ROCK PAPER SCISSORS LIZZARD SPOCK!!");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            while (playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("PLayer Score -  " + playerScore + " Enemy Score -  " + enemyScore);
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Please Enter 'r' For ROCK, 'p' For PAPER, 's' For SCISSORS, 'l' For LIZZARD, or anything else For SPOCK");
                string playerChoice = Console.ReadLine();


                int enemyChoice = random.Next(0, 5);

                if(enemyChoice ==0 ) // If Enemy Chooses Rock and the outcomes of the battle
                {
                    Console.WriteLine("Enemy Chooses ROCK");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;

                        case "p":
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break ;

                        case "s":
                            Console.WriteLine("Enemy Wins");
                            enemyScore++;
                            break;

                        case "l":
                            Console.WriteLine("Enemy wins");
                            enemyScore++;
                            break;

                        default: //Spock
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;
                    }

                }
                else if(enemyChoice ==1) // If Enemy Chooses Paper and the outcome of the battle
                {
                    Console.WriteLine("Enemy Chooses PAPER");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy Wins!");
                            enemyScore++;
                            break;

                        case "p":
                            Console.WriteLine("Tie!");
                            break;

                        case "s":
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;

                        case "l":
                            Console.WriteLine("Player wins!!");
                            playerScore++;
                            break;

                        default: //Spock
                            Console.WriteLine("Enemy Wins!");
                            enemyScore++;
                            break;
                    }

                }
                else if(enemyChoice ==2) // If Enemy chooses Scissors and the outcome of the battle
                {
                    Console.WriteLine("Enemy Chooses SCISSORS");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;

                        case "p":
                            Console.WriteLine("Enemy Wins");
                            enemyScore++;
                            break;

                        case "s":
                            Console.WriteLine("Tie!");
                            break;

                        case "l":
                            Console.WriteLine("Enemy Wins");
                            enemyScore++;
                            break;

                        default:
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;

                    }

                }
                else if(enemyChoice ==3) // If enemy chooses Lizzard and the outcomes of the battle
                {
                    Console.WriteLine("Enemy Chooses LIZZARD");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;

                        case "p":
                            Console.WriteLine("Enemy Wins");
                            enemyScore++;
                            break;

                        case "s":
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;

                        case "l":
                            Console.WriteLine("Tie");
                            break;

                        default:
                            Console.WriteLine("Enemy Wins!");
                            enemyScore++;
                            break;

                    }



                }
                else // If enemy chooses Spock and the outcome of the battle
                {
                    Console.WriteLine("Enemy Chooses SPOCK");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy Wins!");
                            enemyScore++;
                            break;

                        case "p":
                            Console.WriteLine("player Wins!!");
                            playerScore++;
                            break;

                        case "s":
                            Console.WriteLine("Enemy Wins!");
                            enemyScore++;
                            break;

                        case "l":
                            Console.WriteLine("Player Wins!!");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("Tie");
                            break;

                    }
                  

                }
            }

            Console.Clear(); // End of game and final results

            if(playerScore == 3)
            {
               
                Console.WriteLine("YOU WIN!!!");
                Console.WriteLine("-----------");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("GAME OVER");
                Console.WriteLine("-----------");
                Console.ReadLine();
            }



        }
    }
}
