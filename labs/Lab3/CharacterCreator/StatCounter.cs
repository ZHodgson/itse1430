/*Zachary Hodgson
 * ITSE 1430
 * Mr. Taylor
 * Lab 3
 * 4/21/2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public static class StatCounter
    {
        public static void AddStat ( string pointsRemaining, string statIncrease, out string newPointsRemaining, out string newStatTotal )
        {
            var temp = Int32.Parse(pointsRemaining);
            if (temp == 0)
            {
                newPointsRemaining = null;
                newStatTotal = null;
                return;
            } else
            
            {
                temp -= 1;
                newPointsRemaining = temp.ToString();
                temp = Int32.Parse(statIncrease);
                temp += 1;
                newStatTotal = temp.ToString();
                return;
            }
        }

        public static void SubtractStat ( string pointsRemaining, string statIncrease, out string newPointsRemaining, out string newStatTotal )
        {
            var temp = Int32.Parse(statIncrease);
            
            if (temp == 50)
            {
                newPointsRemaining = null;
                newStatTotal = null;
                return;
            } else
            
            {
                temp -= 1;
                newStatTotal = temp.ToString();
                temp = Int32.Parse(pointsRemaining);
                temp += 1;
                newPointsRemaining = temp.ToString();
                return;
            }
        }
    }
}
