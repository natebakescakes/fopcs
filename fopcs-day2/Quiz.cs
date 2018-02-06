using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day2
{
    public class Quiz
    {
        // Not the taxi question, the discount is a mass-discount on the total
        public static double InitialAnswer(int noOfItems)
        {
            double totalCost = 500 * noOfItems;
            double totalCostAfterDiscount = totalCost;

            if (totalCost > 2000) totalCostAfterDiscount -= Math.Min(1000, totalCost - 2000) * 0.03;
            if (totalCost > 3000) totalCostAfterDiscount -= Math.Min(3000, totalCost - 3000) * 0.05;
            if (totalCost > 6000) totalCostAfterDiscount -= (totalCost - 6000) * 0.08;

            return totalCostAfterDiscount;
        }

        public static double CorrectAnswer(int noOfItems)
        {
            double initialCost = 500 * noOfItems;

            if (initialCost > 2000 && initialCost <= 3000)
            {
                return initialCost * 0.97;
            }
            else if (initialCost > 3000 && initialCost <= 6000)
            {
                return initialCost * 0.95;
            }
            else if (initialCost > 6000)
            {
                return initialCost * 0.92;
            }
            else
            {
                return initialCost;
            }
        }

        public static double AlternativeAnswer(int noOfItems)
        {
            double initialCost = 500 * noOfItems;

            if (initialCost > 6000)
            {
                return initialCost * 0.92;
            }
            else if (initialCost > 3000)
            {
                return initialCost * 0.95;
            }
            else if (initialCost > 2000)
            {
                return initialCost * 0.97;
            }
            else
            {
                return initialCost;
            }
        }
    }
}
