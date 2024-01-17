using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{//Create RollDice Class
    public class RollDice
    {
        private Random random;

        public RollDice()
        {//Create Random variable
            random = new Random();
        }
        //Create RollSim method that simulates dice roll and adds count of results to an array
        public int[] RollSim(int n)
        {
            int[] results = new int[11];

            for (int i = 0; i < n; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2;

                results[sum - 2]++;
            }
            //return the results that will be used in Program class
            return results;

        }
    }
}
