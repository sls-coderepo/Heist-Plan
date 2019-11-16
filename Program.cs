﻿using System;
using System.Collections.Generic;

namespace Heist_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> members = new Dictionary<string, Dictionary<string, decimal>>();
            string message = "Plane Your Heist!";
            Console.WriteLine(message);

            string name;
            int skillLevel;
            decimal courageFactor;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your skill level?");
            skillLevel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your Courage Factor?");
            courageFactor = Convert.ToDecimal(Console.ReadLine());

            members.Add(name, new Dictionary<string, decimal>()
            { { "skillLevel", skillLevel }, { "courageFactor", courageFactor }
            });

            foreach (KeyValuePair<string, Dictionary<string, decimal>> member in members)
            {
                Console.WriteLine($"{member.Key} has skill of {member.Value["skillLevel"]} and courage of {member.Value["courageFactor"]}");
            }

        }
    }
}