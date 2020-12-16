using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
       
            public static int solution(int a, int b, int c, int d)
    {
        int returnCount = 0;

        List<int> cx = new List<int>();
        used = new bool[4];
        comb = new List<List<int>>();
        GetComb(new int[] { a, b, c, d }, 0, cx);
                foreach (var item in comb)
        {
            string time = String.Format($"{item[0]}{item[1]}:{item[2]}{item[3]}:00");
            try
            {
                DateTime dt = Convert.ToDateTime(time);
                Console.WriteLine(time);
                returnCount++;
            }
            catch { }
        }


        return returnCount;
    }

    // https://stackoverflow.com/questions/1952153/what-is-the-best-way-to-find-all-combinations-of-items-in-an-array

    static List<List<int>> comb;
    static bool[] used;

    static void GetComb(int[] arr, int colindex, List<int> c)
    {

        if (colindex >= arr.Length)
        {
            comb.Add(new List<int>(c));
            return;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (!used[i])
            {
                used[i] = true;
                c.Add(arr[i]);
                  //c = c.Distinct().ToList();
                    GetComb(arr, colindex + 1, c);
                c.RemoveAt(c.Count - 1);
                used[i] = false;
            }
        }
    }
            

        static void Main(string[] args)
        {
            Console.WriteLine(solution(1, 8, 6, 2));
        }
    }
}
