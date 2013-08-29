using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactorsProject
{
    public class PrimeFactors
    {
        public static void Main() { 
        
        }

        public static List<int> Generate(int rootNumber)
        {
            List<int> factors = new List<int>();
            int valueUpToRootNumber = 2;

            while (rootNumber > 1)
            {
                while (rootNumber % valueUpToRootNumber == 0)
                {
                    factors.Add(valueUpToRootNumber);
                    rootNumber = rootNumber / valueUpToRootNumber;
                }
                valueUpToRootNumber++;
            }
            if (rootNumber > 1)
            {
                factors.Add(rootNumber);
            }
            return factors;
        }
    }
}
