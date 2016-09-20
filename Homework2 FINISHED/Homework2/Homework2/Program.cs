using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //scene 1
            Console.WriteLine("SCENE ONE: You wake up in the middle of the night to use the bathroom.");
            Console.WriteLine("A book tumbles its way to the floor from your shelf across the room.");
            Console.WriteLine("Looking over toward the noise, you notice that your closet door has been opened.");
            
            //3 choices that will determine the player's outcome at the ending of the game
            Console.WriteLine();
            Console.WriteLine("Choices:");
            Console.WriteLine("Go back to SLEEP"); //cowardice ++
            Console.WriteLine("Get up and go to the BATHROOM"); //bravery ++
            Console.WriteLine("Shut the CLOSET door"); //intel ++
            Console.Write("What do you do? ");
            string firstChoice = Console.ReadLine().ToLower().Trim();

            //creates a variable for the loop, so that it's easier to figure out whether the player has entered an incorrect choice
            var playerRight = 0;

            //creates a bonus scene for scene 2 if they choose the bravery option
            var playerBravery = 0;

            //variables from S1 that determine the ending
            var playerSleep = 0;
            var playerCloset = 0;
            

            //determines the result of the player's first decision

            while (playerRight != 1)
            {
                switch (firstChoice)
                {
                    case "sleep":
                        Console.WriteLine("You start to feel extremely uneasy and try your best to go back to sleep.");
                        playerRight += 1;
                        playerSleep += 1;
                        break;
                    case "bathroom":
                        Console.WriteLine("You assume nothing of the noise and, feeling brave, get up to go to the bathroom.");
                        playerRight += 1;
                        playerBravery += 1;
                        break;
                    case "closet":
                        Console.WriteLine("You are immediately suspicious of the closet door and get up to close it.");
                        playerRight += 1;
                        playerCloset += 1;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Console.Write("Please choose again: ");
                        firstChoice = Console.ReadLine().ToLower().Trim();
                        break;
                }
                continue;
            }
            
            

            //go back to sleep --> player's cowardice goes up
            //go to the bathroom --> player's bravery goes up --> if they make this choice, they act more bravely in scene 2
            //shut the closet door --> player's intelligence goes up

            //variables from S2 that determine the ending
            var playerBlanket = 0;
            var playerWeapon = 0;
            var playerOpen = 0;
            //scene 2
            Console.WriteLine();
            if (playerBravery == 1)
            {
                Console.WriteLine("You return to your room after using the bathroom.");
            }
            Console.WriteLine();
            Console.WriteLine("SCENE TWO: The room falls into a sinister silence.");
            Console.WriteLine("You turn onto your back and stare up at the ceiling.");
            Console.WriteLine("Closing your eyes, you start to drift back into sleep.");
            Console.WriteLine("Suddenly you hear a tapping noise from your window. You jolt back up.");

            //2 choices for scene 2
            Console.WriteLine();
            Console.WriteLine("Choices:");
            Console.WriteLine("Hide under your BLANKET");   ///cowardice ++
            Console.WriteLine("Open up your end table for a WEAPON");  //intel ++
            if (playerBravery == 1)
            {
                Console.WriteLine("You start to feel a sense of bravery from facing your fears earlier.");
                Console.WriteLine("You also have the option to OPEN the window."); //bravery ++
            }
            Console.Write("What do you do? ");
            string secondChoice = Console.ReadLine().ToLower().Trim();


            //creates a variable for the loop, so that it's easier to figure out whether the player has entered an incorrect choice
            var newPlayerRight = 0;


            //determines the result of the player's second choice
            while (newPlayerRight != 1)
            {
                switch (secondChoice)
                {
                    case "blanket":
                        Console.WriteLine("You feel paralyzed with fear and throw your blanket over yourself.");
                        newPlayerRight += 1;
                        playerBlanket += 1;
                        break;
                    case "weapon":
                        Console.WriteLine("You reach into the drawer beside you and grab a weapon to defend yourself with.");
                        newPlayerRight += 1;
                        playerWeapon += 1;
                        break;
                    case "open":
                        Console.WriteLine("Whatever lurks outside can't shake your bravery. You open up the window and have a look.");
                        newPlayerRight += 1;
                        playerOpen += 1;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        Console.Write("Choose again: ");
                        secondChoice = Console.ReadLine().ToLower().Trim();
                        break;
                }
                continue;
            }
            

            //look out the window --> decreases player's caution, puts their guard down
            //open up the end table --> increases player's caution, puts their guard up

            //scene 3
            Console.WriteLine();
            Console.WriteLine("SCENE THREE: You leap out of bed just in time.");
            Console.WriteLine("A shadowy figure breaks through your window and lunges forward at you.");
            Console.WriteLine("You take a few steps back, trembling as you lean your back against the wall.");

            Console.WriteLine();
            Console.WriteLine("Earlier you chose: " + firstChoice + " and " + secondChoice);
            Console.WriteLine();

            //choosing any cowardice choice will get the bad end
            if(playerSleep == 1 && playerBlanket == 1) //extreme coward ending END 1
            {
                Console.WriteLine("Your cowardice has now become your own demise.");
                Console.WriteLine("The monster senses your fear and immediately takes the chance to attack you.");
                Console.WriteLine("BAD END.");
            }
            if(playerSleep == 1 && playerWeapon == 1)
            {
                 Console.WriteLine("Your cowardice from act one has now become your own demise.");
                 Console.WriteLine("The monster senses your fear and immediately takes the chance to attack you.");
                 Console.WriteLine("BAD END.");
            }
            if(playerBravery == 1 && playerBlanket == 1)
            {
                Console.WriteLine("Your cowardice has now become your own demise.");
                Console.WriteLine("The monster senses your fear and immediately takes the chance to attack you.");
                Console.WriteLine("BAD END.");
            }
            if(playerCloset == 1 && playerBlanket == 1)
            {
                Console.WriteLine("Your cowardice has now become your own demise.");
                Console.WriteLine("The monster senses your fear and immediately takes the chance to attack you.");
                Console.WriteLine("BAD END.");
            }

            //END 2
            if(playerBravery == 1 && playerWeapon == 1) 
            {
                Console.WriteLine("Your bravery and intelligence have come to your rescue.");
                Console.WriteLine("You leap forward, attacking the monster with the weapon you grabbed.");
                Console.WriteLine("The monster is slain, and you can safely return to bed.");
                Console.WriteLine("END.");
            }
            if(playerBravery == 1 && playerOpen == 1) // 2 brave choices, best ending END 3
            {
                Console.WriteLine("Your brave decisions have come to your rescue.");
                Console.WriteLine("You sprint past the monster, leaping out of the window you opened before.");
                Console.WriteLine("You run down your street, safely escaped from the monster.");
                Console.WriteLine("GOOD END.");
            }

            //intelligence ending END 4 
            if(playerCloset == 1 && playerWeapon == 1)
            {
                Console.WriteLine("Your intelligence has saved your life this time.");
                Console.WriteLine("You plunge the weapon into the monster's side,");
                Console.WriteLine("giving you just enough time to escape.");
                Console.WriteLine("INTELLIGENCE END.");
            }

            //outcomes --> survive or die based on decisions
            //having more bravery and intelligence will increase the chances of survival
            //choosing any cowardly choices results in a bad end

        }
    }
}
