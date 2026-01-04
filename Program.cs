using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
 
    public static int countResponseTimeRegressions(List<int> responseTimes)
    {
if (!responseTimes.Any()||responseTimes.Count<2) return 0;

long sum = responseTimes[0];
int count=0;

for (int i = 1; i < responseTimes.Count; i++)
    {
        double avg = (double)sum / i;
        if (responseTimes[i] > avg)
            count++;
        sum += responseTimes[i];
    }

    return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insert the array lenght");
        int responseTimesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> responseTimes = new List<int>();

        for (int i = 0; i < responseTimesCount; i++)
        {
            Console.Write($"Insert the {i+1} value:");
            int responseTimesItem = Convert.ToInt32(Console.ReadLine().Trim());
            responseTimes.Add(responseTimesItem);
        }

        int result = Result.countResponseTimeRegressions(responseTimes);

        Console.WriteLine("="+result);
    }
}
