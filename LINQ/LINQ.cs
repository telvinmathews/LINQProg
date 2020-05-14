using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LINQ
    {
        List<string> Words;
        List<string> names;
        List<string> Grades;


        public LINQ()
        {
            Words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            Grades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

        }
        public List<string> SelectWordQuery()
        {
            var myLinqQuery = from word in Words
                              where word.Contains("th")
                              select word;
                              
            return myLinqQuery.ToList();
        }

        public List<string> NoDupList()
        {
            var distinctList = names.Distinct();
            foreach (var name in distinctList)
            {
                Console.WriteLine();
            }
            return distinctList.ToList();
        }



        // Calculates class grade average after dropping the lowest grade for each student.
        public double ClassGradeAverage(List<string> list)
        {
            string[] stringArray;
            double[] doubleArray;

            double[] stringAverages = new double[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                stringArray = list[i].Split(',');
                doubleArray = new double[stringArray.Length];

                for (int j = 0; j < stringArray.Length; j++)
                    doubleArray[j] = int.Parse(stringArray[j]);

                stringAverages[i] = (doubleArray.Where(s => s != doubleArray.Min())).Average();
            }
            return stringAverages.Average();
        }
        
        // Returns alphabetically ordered string of letter frequency.
        public string GetLetterFreq(string input)
        {
            string rtnStr = "";

            var groups = input.ToUpper().ToArray().GroupBy(c => c).OrderBy(c => c.Key);

            foreach (var g in groups)
            {
                rtnStr += g.Key + g.Count().ToString();
            }
            return rtnStr;
        }


        //in order to calulate the average of a list string of numbers 
        //first convert list to int
        //delete number <= 69
        //then look through list and add the sum of the numbers
        //then divide that sum by the count
    }
}
//foreach (var word in myLinqQuery)
//{
//    return 
//    //Console.WriteLine(word + " ");
//}
//Console.ReadLine();