using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekseat_Witch_Saga
{
    public class Calculate
    {
        private int num;
        private int sum;
        public int[] GetKilled(int age, int year)
        {
            int v1 = 1, v2 = 1, v3, i;
            num = year - age;

            if (num < 3)
                return new int[2] { num, num };

            sum = v1 + v2;
            for (i = 2; i < num; i++)
            {
                v3 = v1 + v2;
                sum += v3;
                v1 = v2;
                v2 = v3;
            }
            return new int[2] { num, sum };
        }

        public double AVG(int valA, int ValB) => (double)(valA+ValB)/2;
    }
}
