using System;
using System.Collections;
using System.Collections.Generic;

namespace day_3
{
    class BinaryDiagnostic
    {
        static void Main(string[] args)
        {
            List<string> data = getData(@"../../../input.txt");
        
            (BitArray gamma, BitArray epsilon) powerRate = getPowerRate(data);

            int gamaValue = getIntFromBitArray(powerRate.gamma);
            int epsilonValue = getIntFromBitArray(powerRate.epsilon);

            int answer = gamaValue * epsilonValue;

            Console.WriteLine(answer);

        }

        private static List<string> getData(string file)
        {
            List<string> data = new List<string>();
            foreach (string line in System.IO.File.ReadLines(file))

            {
                data.Add(line);
            }
            return data;
        }

        private static (BitArray, BitArray) getPowerRate(List<string> data)
        {
            BitArray gamma = new BitArray(12);
            BitArray epsilon = new BitArray(12);
            int[] bitFreq = new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        
            foreach(string line in data)
            {
                for(int i = 0; i < 12; i++)
                {
                    if(line[i] == '1')
                    {
                        bitFreq[i] += 1;
                    }
                }
            }
            for(int i = 0; i < 12; i ++)
            {
                int majority = data.Count / 2;
                if(bitFreq[i] > majority)
                {
                    gamma.Set(i, true);
                    epsilon.Set(i, false);
                }
                else
                {
                    gamma.Set(i, false);
                    epsilon.Set(i, true);
                }
            }

            return (gamma, epsilon);
        }

        private static int getIntFromBitArray(BitArray bitArray)
        {
            double total = 0;
            for(int i = 0; i < 12; i++)
            {
                if (bitArray[11 - i])
                {
                    total += Math.Pow(2, i);
                }
            }
            return Convert.ToInt32(total);

        }
    }
}
