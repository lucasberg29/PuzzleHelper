using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleHelper
{
    internal class Character
    {
        public string Name { get; set; } = "unknown";
        public string Color { get; set; } = "unknown";
        public int RowPosition { get; set; } = -1; // Default to -1 for "unknown"
        public string City { get; set; } = "unknown";
        public string Drink { get; set; } = "unknown";
        public string Heirloom { get; set; } = "unknown";

        public List<string> PossibleNames { get; set; } = new List<string>();
        public List<string> ImpossibleNames { get; set; } = new List<string>();

        public List<string> PossibleColors { get; set; } = new List<string>();
        public List<string> ImpossibleColors { get; set; } = new List<string>();

        public List<int> PossibleRowPosition { get; set; } = new List<int>();
        public List<int> ImpossibleRowPosition { get; set; } = new List<int>();

        public List<string> PossibleCities { get; set; } = new List<string>();
        public List<string> ImpossibleCities { get; set; } = new List<string>();

        public List<string> PossibleDrinks { get; set; } = new List<string>();
        public List<string> ImpossibleDrinks { get; set; } = new List<string>();

        public List<string> PossibleHeirlooms { get; set; } = new List<string>();
        public List<string> ImpossibleHeirlooms { get; set; } = new List<string>();

        public Character() { }

        public Character(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"RowPosition: {RowPosition}");
            sb.AppendLine($"City: {City}");
            sb.AppendLine($"Drink: {Drink}");
            sb.AppendLine($"Heirloom: {Heirloom}");
            return sb.ToString();
        }
    }
}
