using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumEqualZero
{
    internal class ArrayAdditionToZero
    {

        public void sumEqualZero()
        {

            static bool isEven(int x)
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("Entrez un nombre entier.");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intsArray = new int[n];

            if (isEven(n))
            {
                for (int i = 0; i < n; i++)
                {
                    if (-(n / 2) + i < 0)
                    {
                        intsArray[i] = -(n / 2) + i;
                    }
                    else
                    {
                        intsArray[i] = -(n / 2) + i + 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {

                    intsArray[i] = -((n - 1) / 2) + i;

                }
            }

            foreach (int x in intsArray)
            {
                Console.WriteLine(x);
            }
        }

    }
}
