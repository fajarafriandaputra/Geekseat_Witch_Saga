using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekseat_Witch_Saga
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculate cal = new Calculate();
            string AgeA, AgeB, YearA, YearB;
            int vAgeA, vAgeB, vYearA, vYearB, ValA, ValB;
            int[] result;
            while (true)
            {
                Console.WriteLine(Helpers.personA);
                Console.Write(Helpers.ageofDeath);
                AgeA = Console.ReadLine().Trim();
                Console.Write(Helpers.yearofDeath);
                YearA = Console.ReadLine().Trim();
                Console.WriteLine("\n----------------------\n");
                Console.WriteLine(Helpers.personB);
                Console.Write(Helpers.ageofDeath);
                AgeB = Console.ReadLine().Trim();
                Console.Write(Helpers.yearofDeath);
                YearB = Console.ReadLine().Trim();

                //Validation
                if (!Int32.TryParse(AgeA, out vAgeA) ||
                    !Int32.TryParse(YearA, out vYearA) ||
                    !Int32.TryParse(AgeB, out vAgeB) ||
                    !Int32.TryParse(YearB, out vYearB) ||
                    ((vYearA - vAgeA) < 0) ||
                    ((vYearB - vAgeB) < 0))
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine(Helpers.notValid);
                    Console.WriteLine(Helpers.msgNotValid);
                }
                else
                {
                    //Function Calculate Person A
                    Console.WriteLine("\n----------------------\n");
                    result = cal.GetKilled(vAgeA, vYearA);
                    string resultA = String.Format(Helpers.result, new object[6] {
                        Helpers.personA, vYearA, vAgeA, result[0], result[0], result[1]
                    });
                    ValA = result[1];
                    Console.WriteLine("{0}", resultA);

                    //Function Calculate Person B
                    result = cal.GetKilled(vAgeB, vYearB);
                    string resultB = String.Format(Helpers.result, new object[6] {
                        Helpers.personB, vYearB, vAgeB, result[0], result[0], result[1]
                    });
                    ValB = result[1];
                    Console.WriteLine("{0}", resultB);

                    //Function Average
                    double Average = cal.AVG(ValA, ValB);
                    Console.WriteLine(Helpers.Average, new object[3] {
                        ValA,ValB,Average
                    });
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
