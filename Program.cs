using System;
using System.Collections.Generic;

namespace Heist_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Plane Your Heist!";
            Console.WriteLine(message);
            Console.WriteLine("==============================================");
            Console.Write("Enter difficulty level of the bank: ");
            int bankDifficultyLevel = Convert.ToInt32(Console.ReadLine());

            List<Member> members = new List<Member>();

            bool startAgain = true;
            string reply;
            //int bankDifficultLevel = 100;
            decimal totalSkillLevel = 0;
            //Prompt for user input
            while (startAgain)
            {

                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.WriteLine("What is your skill level?");
                string skillLevelString = Console.ReadLine();
                int skillLevel;

                try
                {
                    skillLevel = int.Parse(skillLevelString);
                }
                catch (Exception)
                {
                    Console.WriteLine($"{skillLevelString} is not a valid skill level. Using a default value of 10");
                    skillLevel = 10;
                }

                Console.WriteLine("What is your Courage Factor? (0.0 - 2.0)");
                string courageFactorString = Console.ReadLine();
                decimal courageFactor;
                try
                {
                    courageFactor = decimal.Parse(courageFactorString);
                }
                catch (Exception)
                {
                    Console.WriteLine($"{courageFactorString} is not a valid courage factor. Using a default value of 1.0");
                    courageFactor = 1.0M;
                }

                Console.Write("Add new member? (Y or N):  ");
                reply = Console.ReadLine();
                reply = reply.ToUpper();
                if (reply != "Y")
                {
                    startAgain = false;
                }
                // adding member to the member list
                Member member = new Member()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    CourageFactor = courageFactor
                };

                members.Add(member);
            }
            Console.WriteLine("==============================================");
            Console.WriteLine($"There are {members.Count} members in your team!");

            foreach (var member in members)
            {
                Console.WriteLine($"{member.Name} has skill of {member.SkillLevel} and courage of {member.CourageFactor}");
            }
            Console.WriteLine("==============================================");

            //adding skill level
            foreach (var member in members)
            {
                totalSkillLevel += member.SkillLevel;

            }
            // Random Number 
            Random rand = new Random();



            Console.Write("Enter number of trial runs: ");
            int numberOfTrail = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < numberOfTrail; i++)
            {

                int currentBankDifficultLevel = bankDifficultyLevel;
                currentBankDifficultLevel += rand.Next(-10, 10);

                if (totalSkillLevel >= currentBankDifficultLevel)
                {
                    Console.WriteLine("We have enough skill level to heist the bank!");
                }
                else
                {
                    Console.WriteLine("Sorry, We cant heist the bank!");
                }
                Console.WriteLine($"Bank Difficulty Level-- {currentBankDifficultLevel}");
                Console.WriteLine($"Total Skill Level-- {totalSkillLevel}");

            }


        }

    }
}