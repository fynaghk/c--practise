// simpleArraySum

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
    public static int simpleArraySum(List<int> ar)
    {
        int sum = 0;
        foreach (int num in ar)
        {
            sum += num;
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());
        Console.SetOut(textWriter);
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

// compareTriplets

class Result
{
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int comp1 = 0;
        int comp2 = 0;
       for(int i = 0; i<a.Count; i++){
            if(a[i]<b[i]){
              comp2=comp2+1;
            }
            else if(a[i]>b[i]){
              comp1=comp1+1;
            }else{
                continue;
            }
       }
        List<int> arr = new List<int>() { comp1, comp2 };
        return arr;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}


//aVeryBigSum

class Result
{
    public static long aVeryBigSum(List<long> ar)
    {
        long result=0;
        
        foreach(long number in ar){
            result=result+number;
        }
        
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

