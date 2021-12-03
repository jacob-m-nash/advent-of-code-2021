using System;
using System.Collections.Generic;

namespace day2
{
    class DiveController
    {


        static void Main(string[] args)
        {
            Submarine submarine = new Submarine();
            List<(string, int)> commands = getCommands(@"../../../input.txt");
            submarine.ExicuteCommands(commands);
            int answer = submarine.horizontalPos * submarine.verticalPos;
            Console.WriteLine(answer);

            
        }

        static List<(string,int)> getCommands(string file)
        {
            List<(string, int)> commands = new List<(string, int)>();
            foreach (string line in System.IO.File.ReadLines(file))
            {
                var substing = line.Split(" ");
                commands.Add((substing[0], int.Parse(substing[1])));
            }
            return commands;
        }
    }
}
