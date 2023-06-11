using Probleme_Chiffre_Affaire.Models;
using System;
using System.Collections.Generic;

// This namespace contains helper classes.
namespace Probleme_Chiffre_Affaire.Helper
{
    // This class provides methods to calculate maximum revenue.
    public class CalcRevenuMax
    {
        // This static method calculates the maximum possible revenue 
        // given a certain capacity and a list of families. 
        // The algorithm is a variant of the Knapsack problem.
        // "dp" stands for "dynamic programming" and is used to store intermediate results 
        // for optimization purposes.
        // "chosenFamilies" is a two-dimensional list that stores which families are chosen for each sub-problem.
        public static Tuple<int, List<Family>> CalculerRevenuMaximum(int capacity, List<Family> families, int n, int[][] dp, List<Family>[][] chosenFamilies)
        {
            // Base case of the recursion: if there are no more families to process (n == 0) 
            // or the capacity is exhausted (capacity == 0), we return 0 and an empty list.
            if (n == 0 || capacity == 0)
                return Tuple.Create(0, new List<Family>());

            // If we have already solved this sub-problem before, return the stored result to avoid recomputation.
            if (dp[n][capacity] != -1)
                return Tuple.Create(dp[n][capacity], chosenFamilies[n][capacity]);

            // If the current family can be accommodated within the remaining capacity, we have two options: 
            // either we include the family in the solution or we don't.
            if (families[n - 1].Members.Count <= capacity)
            {
                // Option 1: include the current family. The remaining capacity reduces by the size of the current family.
                var option1 = CalculerRevenuMaximum(capacity - families[n - 1].Members.Count, families, n - 1, dp, chosenFamilies);
                var option1Value = families[n - 1].TotalPrice + option1.Item1;

                // Option 2: exclude the current family. The remaining capacity and number of families both reduce.
                var option2 = CalculerRevenuMaximum(capacity, families, n - 1, dp, chosenFamilies);

                // We select the option that gives the maximum total price.
                // And update the chosen families and dp array accordingly.
                if (option1Value > option2.Item1)
                {
                    dp[n][capacity] = option1Value;
                    chosenFamilies[n][capacity] = new List<Family>(option1.Item2) { families[n - 1] };
                }
                else
                {
                    dp[n][capacity] = option2.Item1;
                    chosenFamilies[n][capacity] = new List<Family>(option2.Item2);
                }
            }
            else
            {
                // If the current family cannot be accommodated, we have no choice but to exclude it.
                var option = CalculerRevenuMaximum(capacity, families, n - 1, dp, chosenFamilies);
                dp[n][capacity] = option.Item1;
                chosenFamilies[n][capacity] = new List<Family>(option.Item2);
            }

            // Return the maximum total price and the list of chosen families for the current sub-problem.
            return Tuple.Create(dp[n][capacity], chosenFamilies[n][capacity]);
        }

    }
}
