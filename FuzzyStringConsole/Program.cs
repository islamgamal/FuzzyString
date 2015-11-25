using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuzzyString;

namespace FuzzyStringConsole
{
    class Program
    {
        static void Main(string[] args)
        { 
            string kevin = "kevin";
            string kevyn = "kevyn";

            List<FuzzyStringComparisonOptions> options = new List<FuzzyStringComparisonOptions>();
            options.Add(FuzzyStringComparisonOptions.UseJaccardDistance);
            options.Add(FuzzyStringComparisonOptions.UseNormalizedLevenshteinDistance);
            options.Add(FuzzyStringComparisonOptions.UseOverlapCoefficient);
            options.Add(FuzzyStringComparisonOptions.UseLongestCommonSubsequence);
            options.Add(FuzzyStringComparisonOptions.CaseSensitive);

            Console.WriteLine(kevin.ApproximatelyEquals(kevyn, options, FuzzyStringComparisonTolerance.Weak));
            Console.WriteLine(kevin.ApproximatelyEquals(kevyn, options, FuzzyStringComparisonTolerance.Normal));
            Console.WriteLine(kevin.ApproximatelyEquals(kevyn, options, FuzzyStringComparisonTolerance.Strong));

            Console.ReadLine();
        }
    }
}
