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
            int previousDepth = depths[0];
            int numberOfDepthIncrese = 0;

            for(int i = 1; i < depths.Count; i++)
            {
                int currentDepth = depths[i];
                if(previousDepth < currentDepth)
                {
                    numberOfDepthIncrese++;
                }
                previousDepth = currentDepth;

            }

            return numberOfDepthIncrese;

        }
    }
}
