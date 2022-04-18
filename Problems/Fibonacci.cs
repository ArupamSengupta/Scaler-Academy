using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        // YOUR CODE GOES HERE
        // Please take input and print output to standard input/output (stdin/stdout)
        // DO NOT USE ARGUMENTS FOR INPUT
        // E.g. 'StreamReader' for input & 'StreamWriter' for output
        string val = Console.ReadLine();
        int A = Convert.ToInt32(val);

        int[] fibArr = setupFibArr();
        Console.WriteLine(fibArr[A]);
        
    }

    public static int[] setupFibArr(){
        
        int[] fibArr = new int[45];
        fibArr[0]=0;
        fibArr[1]=1;

        for (int index=2; index<=44; index++) {
            fibArr[index]= fibArr[index-1] + fibArr[index-2];
        }

        return fibArr;
    }
}