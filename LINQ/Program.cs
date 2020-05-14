using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ lINQ = new LINQ();
            lINQ.GetLetterFreq("telvin");
            var ReturnedListQuery = lINQ.SelectWordQuery();
            foreach (string s in ReturnedListQuery)
            {
                Console.WriteLine(s + " ");
            }

            var ReturnedDistinctList = lINQ.NoDupList();
            foreach (string s in ReturnedDistinctList)
            {
                Console.WriteLine(s);
            }

           // Console.WriteLine(ReturnedListQuery);
            Console.ReadLine();
        } 
    }
}
;