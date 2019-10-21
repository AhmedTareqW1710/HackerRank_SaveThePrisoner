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

class Solution
{

    // Complete the saveThePrisoner function below.
    static int saveThePrisoner(int n, int m, int s)
    {
        int prisonerNumber = 0;
        int newSweetsNumber = 0;
        int remainingSweets = 0;

        // If number of prisoners greater than sweets number       
        if (n >= m)
        {
            if (m <= n - s)
            {
                prisonerNumber = s + m - 1;
            }
            else if (m > n - s)
            {
                newSweetsNumber = m - (n - s) - 1;
                if (newSweetsNumber == 0)
                {
                    prisonerNumber = n;
                }
                else
                prisonerNumber = newSweetsNumber;
            }
        }

        // If number of sweets more than prisoners number
        else if (m > n)
        {
            newSweetsNumber = m - (n - s) - 1;

            if (newSweetsNumber <= n)
            {
                prisonerNumber = newSweetsNumber;
            }
            else
            {
                remainingSweets = newSweetsNumber % n;
                if (remainingSweets == 0)
                {
                    prisonerNumber = n;
                }
                else
                {
                    prisonerNumber = remainingSweets;
                }
            }
            
        }
        return prisonerNumber;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nms = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = saveThePrisoner(n, m, s);

            Console.WriteLine(result);

        }

        Console.ReadKey();
    }
}
