using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fopcs_day5
{
    public class Quiz
    {
        static int[] minIncomeArray = new int[]
        {
            20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000
        };
        static double[] taxRateArray = new double[]
        {
            0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20
        };
        static int[] basePayableAmountArray = new int[]
        {
            0, 200, 550, 3350, 7950 ,13950, 20750, 42350
        };

        public static void Question()
        {
            int annualIncome = AskforIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        private static void PrintResult(int annualIncome, double taxPayable)
        {
            Console.WriteLine(
                $"For taxable annual income of {annualIncome:C}, the tax payable amount is {taxPayable:C}"
            );
        }

        public static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            if (taxBracket == -1)
                return 0;

            return (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
        }

        public static int GetTaxBracket(int annualIncome)
        {
            for (int i = minIncomeArray.Length-1; i >= 0; i--)
            {
                if (annualIncome > minIncomeArray[i])
                    return i;
            }

            return -1;
        }

        private static int AskforIncome()
        {
            Console.Write("Please enter your annual taxable income: ");

            return Int32.Parse(Console.ReadLine());
        }
    }
}
