using System;
using System.Collections.Generic;

namespace day1
{
    class SonarSweep
    {
        static void Main(string[] args)
        {
            List<int> depthData = GetInput(@"../../../input.txt");
            Console.WriteLine(GetNumberDepthIncrese(depthData));
            
        }

        private static List<int> GetInput(string filename)
        {
            List<int> data = new List<int>();
            foreach (string line in System.IO.File.ReadLines(filename))
            {
                int depth = Int32.Parse(line);
                data.Add(depth);
            }
            return data;
        }

        private static int GetNumberDepthIncrese(List<int> depths)
        {
            int previousDepthsSum = depths[0] + depths[1] + depths[2];
            
            int numberOfDepthIncrese = 0;

            for(int i = 3; i < depths.Count; i++)
            {
                int currentDepthsSum = depths[i-2] + depths[i - 1] + depths[i];
                if(previousDepthsSum < currentDepthsSum)
                {
                    numberOfDepthIncrese++;
                }
                previousDepthsSum = currentDepthsSum;

            }

            return numberOfDepthIncrese;

        }
    }
}
