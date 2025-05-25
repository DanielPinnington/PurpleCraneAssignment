using PurpleCraneAssignment;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> lines = new List<string>();

        Console.WriteLine(" 1) Grid size \n 2) Place on grid \n 3) Movement command \n 4) Second hoover - Place on grid \n 5) Second hoover - Movement Commands \n 6) Empty line (or enter) to finish");
        string? line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            lines.Add(line);
        }

        if (lines.Count < 3 || lines.Count % 2 == 0)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        string[] gridSize = lines[0].Split();
        int maxX = int.Parse(gridSize[0]);
        int maxY = int.Parse(gridSize[1]);

        for (int i = 1; i < lines.Count; i += 2)
        {
            string[] startParts = lines[i].Split();
            int x = int.Parse(startParts[0]);
            int y = int.Parse(startParts[1]);
            Direction dir = ParseDirection(startParts[2]);

            Hoover hoover = new Hoover(x, y, dir, maxX, maxY);

            string commands = lines[i + 1];
            foreach (char cmd in commands)
            {
                hoover.ProcessCommand(cmd);
            }

            Console.WriteLine(hoover);
        }
    }

    static Direction ParseDirection(string input)
    {
        return input.ToUpper() switch
        {
            "N" => Direction.North,
            "E" => Direction.East,
            "S" => Direction.South,
            "W" => Direction.West,
            _ => throw new ArgumentException("Invalid direction")
        };
    }
}
