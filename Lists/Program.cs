using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();
            //add to the list
            scores.Add(18);
            scores.Add(50);
            scores.Add(6);
            scores.Add(12);
            scores.Add(90);

            //insert to thr list
            scores.Insert(3, 80);

            //delete

            scores.RemoveAt(2);
            scores.Remove(50);

            //contain
            bool check = scores.Contains(50);

            //count

            int counter = scores.Count;

            //find index

            int idx = scores.IndexOf(90);

            //change countain
            scores[0] = 40;

            //clear list
            scores.Clear();

         





        }
    }
}
