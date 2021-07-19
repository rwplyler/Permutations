using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutation
{
    /*
Weekly Coding Challenge:

Given array of distinct integers, print all permutations of the array.
For example :
array : [10, 20, 30]

Permutations are :

[10, 20, 30]
[10, 30, 20]
[20, 10, 30]
[20, 30, 10]
[30, 10, 20]
[30, 20, 10]*/
    


    class Program
    {
        static void Main(string[] args)
        {
            int[] start = {10, 20, 30};
            StartPermutation(start);
        }
        /*
         *Function: Converts array to list to start permutation
         */
        static void StartPermutation(int[] variables)
        {
            //Converts the array to a list to make this easier.
            List<int> startingVariables = variables.ToList<int>();
            DoPermutation( null, startingVariables);
            
        }

        /*
         * Function: Goes one by one down a list to call back in to be able to printe each permutation.
         */
        static void DoPermutation(List<int> StartingVariables, List<int> EndingVariables)
        {
            if(EndingVariables == null)
            {

                //mainly just in case I switch to manual inputs
                Console.WriteLine("Emmpty");
            }
            else
            {
                //Running through each variable to make it the start/added on to the previous
                for(int i = 0; i < EndingVariables.Count; i++)
                {
                    //Makes sure that it is infact possible to continue
                    if (EndingVariables.Count != 0)
                    {
                        List<int> start;
                        //Checks to see if there is a list that can be added on to if not it will create the list
                        if (StartingVariables != null)
                        {
                            start = new List<int>(StartingVariables);
                        }
                        else
                        {
                            start = new List<int>();
                        }
                        List<int> dup = new List<int>(EndingVariables);
                        dup.RemoveAt(i);
                        int removed = EndingVariables[i];
                        //adds to the list
                        start.Add(removed);
                        if (dup.Count == 0)
                        {
                            //If it reaches here that means its the end of the line and it prints the line
                            start.ForEach(i => Console.Write("{0}\t", i));
                            Console.Write("\n");
                        }
                        else
                        {
                            //Calls back in on itself to continue
                            DoPermutation(start, dup);
                        }
                    }
                    
                }
            }
        }
    }
}
