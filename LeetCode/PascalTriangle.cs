using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var ret = new List<IList<int>> { };
            var data = new List<int> { };
            var q = new Queue<int>{ };
            if (numRows > 0)
            {
                for (int i = 0; i < numRows; i++)
                {
                    GenerateInternal(data, q);
                    if (data.Count == 0 || data.Count == 1)
                    {
                        data.Insert(0, 1);
                    }
                    ret.Add(data.ToList());
                    q = new Queue<int>(data);
                    data.Clear();

                }
            }

            return ret;
        }
        private void GenerateInternal(List<int> res, Queue<int> data)
        {
            if(data.Count == 0)
            {
                return;
            }

            var pop = data.Dequeue();

            if(pop == 1)
            {
                res.Add(pop);
            }
            
            if(data.Count == 0)
            {
                return;
            }

            var pop2 = data.ElementAt(0);
            
            res.Add(pop + pop2);

            GenerateInternal(res, data);
        }
    }
}
