﻿using System;
using System.Linq;
using HelperLibrary;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = (new FindSmallestMissingIntService()).Run(new int[] { int.MinValue, int.MaxValue }, out double time);
            (new FindSmallestIntSameNumOfDigitsService()).RunTest();
            (new FindMinNumOfStrokesService()).RunTest();
            (new FindLongestBinaryGapService()).RunTest();
        }
    }
}
