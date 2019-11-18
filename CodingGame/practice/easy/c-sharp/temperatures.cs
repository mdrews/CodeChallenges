using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        int distanceToZero = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            
            int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            Console.Error.WriteLine("T: {0}", t);
            if(Math.Abs(t) <= Math.Abs(distanceToZero)){
                Console.Error.WriteLine(Math.Abs(t));
                if(Math.Abs(t) % distanceToZero == 0 && t != distanceToZero){
                    distanceToZero = Math.Abs(distanceToZero);
                }
                else{
                    distanceToZero = t;}
                Console.Error.WriteLine("variable: {0}", distanceToZero);
                }
        }
        if(distanceToZero > 10000){
            distanceToZero = 0;}

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(distanceToZero);
    }
}