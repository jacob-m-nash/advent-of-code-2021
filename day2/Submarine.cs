using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Submarine
    {
        internal int horizontalPos { get; private set; } = 0;
        internal int verticalPos { get; private set; } = 0;

        internal int aim { get; private set; } = 0;


        internal void ExicuteCommands(List<(string, int)> commands)
        {
            foreach((string command,int unit) command in commands)
            {
                switch (command.command)
                {
                    case "forward":
                        horizontalPos += command.unit;
                        verticalPos += aim * command.unit;
                        break;
                    case "up":
                        aim -= command.unit;
                        break;
                    case "down":
                        aim += command.unit;
                        break;
                    default:
                        break;

                }                    
            }
        }
    }
}
