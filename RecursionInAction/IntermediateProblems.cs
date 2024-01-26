using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionInAction
{
    class IntermediateProblems
    {
        //sub-array is contiguous
        #region Sub-sequences
        /*
         it's a contiguous or non-contiguous sequence which follows the order
        for [5,1,2] => [], [5], [1], [2], [5,1], [1,2], [5,2], [5,1,2]
        [5,2,1] or [2,1] are not sub-sequence because order is not followed
         */
        public static int howManySubSequencesGenerated = 0;
        /// <summary>
        /// T.C. : O(n2^n) For every index we have couple of options which is 2^n and we are doing it n times
        /// S.C. : O(n) depth of auxilary space in stack in lenght of array
        /// </summary>
        /// <param name="index"></param>
        /// <param name="array"></param>
        /// <param name="toStoreItemsToPrint">Empty list</param>
        public static void PrintAllSubSequences(int index, List<int> array, List<int> toStoreItemsToPrint)
        {
            if (index == array.Count)
            {
                foreach(var li in toStoreItemsToPrint)
                    Console.Write(li+" ");
                if(toStoreItemsToPrint.Count == 0)
                    Console.Write("{}"); // To represent the empty array
                
                Console.WriteLine("");
                ++howManySubSequencesGenerated;
                return;
            }
            toStoreItemsToPrint.Add(array[index]);
            PrintAllSubSequences(index+1, array, toStoreItemsToPrint); // take last item into consideration
            toStoreItemsToPrint.Remove(array[index]);
            PrintAllSubSequences(index+1, array, toStoreItemsToPrint); // don't take last item into consideration
        }
        #endregion

        //https://www.youtube.com/watch?v=eQCS_v3bw0Q&list=PLgUwDviBIf0rGlzIn_7rsaR2FQ5e6ZOL9&index=7
    }
}
