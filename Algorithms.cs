using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms___Big_O_Lab
{
    internal class Algorithms
    //Task 1: Even or Odd (Time Complexity: Constant O(1))
    {
        public bool OddEven(int number)
        {

            if (number % 2 == 0)
            {
                return true;
            }


            else
            {
                return false;
            }
        }


        //Task 2: Less Than 100 (Time Complexity: Linear O(n) )
        public bool LessThanOneHundred(List<int> numberList)
        {
            bool isLessThanOneHundred = true;

            for (int i = 0; i < numberList.Count; i++)

            {
                if (numberList[i] >= 100)
                {
                    isLessThanOneHundred = false; ;
                }
                else
                {

                }

            }
            return isLessThanOneHundred;
        }
        //Task 3 Repeated Names( Time Complexity:     )
        public bool RepeatedNames(List<string> namesList)
        {
            bool hasARepeatedName = true;
            for (int i = 0; i < namesList.Count; i++)
            {
                if (namesList[i] != namesList[i])
                {
                    hasARepeatedName = false;
                }
                else
                {
                }
            }

            return hasARepeatedName;
        }

        //Task 4 Sort List (Time Complexity:     )


    }
}
