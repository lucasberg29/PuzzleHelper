using System.Diagnostics.Metrics;
using System;

namespace PuzzleHelper
{
    internal class Program
    {
        static List<Character> characters = new();

        static string[] possibleNames =
        {
            "Lady Winslow",
            "Doctor Marcolla",
            "Countess Contee",
            "Madam Natsiou",
            "Baroness Finch"
        };

        static string[] possibleColors =
        {
           "red",
           "purple",
           "green",
           "white",
           "blue"
        };

        static string[] possibleDrinks =
        {
            "rum",
            "wine",
            "beer",
            "whiskey",
            "absinthe"
        };

        static void Main(string[] args)
        {
            for (int i = 0; i < possibleNames.Length; i++)
            {
                Character character = new Character();
                character.RowPosition = i + 1;
                characters.Add(character);
            }

            SolveRiddle();

            PrintResults();
        }

        private static void SolveRiddle()
        {
            // Trivial info
            AddName(0, possibleNames[3]);
            
            AddColor(1, possibleColors[2]);

            AddDrink(2, possibleDrinks[0]);

            // Countess Contee wore a jaunty red hat
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].Name == "Countess Contee")
                {
                    AddColor(i, "red");
                }
            }

            // The lady in blue sat left of someone in purple.
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].Color == "purple")
                {
                    if (i == 0)
                    {
                        Console.WriteLine("WE MESSED UP!");
                    }
                    else
                    {
                        characters[i - 1].Color = "blue";
                        characters[i - 1].Drink = "wine";
                    }
                }
            }

            // The traveler from Fraeport was dressed entirely in white.
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].City == "Fraeport")
                {
                    AddColor(i, "white");
                }
            }

            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].Color == "white")
                {
                    AddCity(i, "Fraeport");
                }
            }

            // When one of the dinner guests...her Diamond,

            // Baroness Finch has a prized War Medal
            foreach (Character character in characters)
            {
                if (character.Name == "Baroness Finch")
                {
                    character.Heirloom = "War Medal";
                }
            }

            foreach (Character character in characters)
            {
                if (character.City == "Karnaca")
                {
                    character.Heirloom = "Bird Pendant";
                }
            }


            CheckImpossibilities();
        }

        private static void CheckImpossibilities()
        {
            foreach (Character character in characters)
            {
                // 4 impossible events
                if (character.ImpossibleNames.Count == 4)
                {

                    for (int i = 0; i < possibleNames.Count(); i++)
                    {
                        bool isPossibleName = true;

                        foreach (string possibleName in character.ImpossibleNames)
                        {

                        }
                    }


                }

            }
        }

        private static void AddName(int index, string name)
        {
            characters[index].Name = name;

            for (int i = 0; i < characters.Count; i++)
            {
                if (index != i)
                {
                    characters[i].ImpossibleNames.Add(name);
                }
            }
        }

        private static void AddColor(int index, string color)
        {
            characters[index].Color = color;

            for (int i = 0; i < characters.Count; i++)
            {
                if (index != i)
                {
                    characters[i].ImpossibleColors.Add(color);
                }
            }
        }

        private static void AddCity(int index, string city)
        {
            characters[index].City = city;

            for (int i = 0; i < characters.Count; i++)
            {
                if (index != i)
                {
                    characters[i].ImpossibleCities.Add(city);
                }
            }
        }

        private static void AddDrink(int index, string drink)
        {
            characters[index].Drink = drink;

            for (int i = 0; i < characters.Count; i++)
            {
                if (index != i)
                {
                    characters[i].ImpossibleDrinks.Add(drink);
                }
            }
        }

        private static void PrintResults()
        {
            foreach (Character character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }
    }
}
