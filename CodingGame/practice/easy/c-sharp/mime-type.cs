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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        
        //custom variables
        Dictionary<string, string> mimes = new Dictionary<string, string>();
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            mimes.Add(EXT.ToLower(), MT);
        }
        foreach(KeyValuePair<string, string> ext in mimes){
            Console.Error.WriteLine("Extensions: {0} - {1}", ext.Key, ext.Value);
        }
        
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.
            Console.Error.WriteLine("FNAME: {0}", FNAME);
            string extension = Path.GetExtension(FNAME).Trim(new Char[] {'.'}).ToLower();
            //Console.Error.WriteLine(extension);
            //Console.Error.WriteLine(mimes[extension]);
            if(mimes.ContainsKey(extension)){
                Console.WriteLine(mimes[extension]);
            }
            else {
                Console.WriteLine("UNKNOWN");
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
        
    }
}