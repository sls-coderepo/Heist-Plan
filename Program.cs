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

            List<Member> members = new List<Member>();


            bool startAgain = true;
            string reply;

            int bankDifficultLevel = 100;
            decimal totalSkillLevel = 0;
            //Prompt for user input
            while (startAgain)
            {
                Member member = new Member();

                Console.WriteLine("What is your name?");
                member.Name = Console.ReadLine();
                if (member.Name == "")
                {
                    break;
                }
                Console.WriteLine("What is your skill level?");
                member.SkillLevel = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is your Courage Factor? (0.0 - 2.0)");
                member.CourageFactor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Add new member? (Y or N):  ");
                reply = Console.ReadLine();
                reply = reply.ToUpper();
                if (reply != "Y")
                {
                    startAgain = false;
                }
                // adding member to the member list
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
            bankDifficultLevel += rand.Next(-10, 10);


            Console.WriteLine($"Bank Difficulty Level-- {bankDifficultLevel}");
            Console.WriteLine($"Total Skill Level-- {totalSkillLevel}");
            if (totalSkillLevel >= bankDifficultLevel)
            {
                Console.WriteLine("We have enough skill level to heist the bank!");
            }
            else
            {
                Console.WriteLine("Sorry, We cant heist the bank!");
            }






        }

    }
}