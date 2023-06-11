using Probleme_Chiffre_Affaire.Helper;
using Probleme_Chiffre_Affaire.Models;
using System;
using System.Collections.Generic;

namespace Probleme_Chiffre_Affaire
{
    class Program
    {
        static void Main(string[] args)
        {
            #region initialisation des exemples
            // Create some example passengers and families.
            var familyA = new Family();
            familyA.FamilyName = "Family A";
            familyA.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyA.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyA.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyA.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyB = new Family();
            familyB.FamilyName = "Family B";
            familyB.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyB.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyB.AddMember(new Passenger(Passenger.PassengerType.Child));


            var familyC = new Family();
            familyC.FamilyName = "Family C";
            familyC.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyC.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyC.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyD = new Family();
            familyD.FamilyName = "Family D";
            familyD.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyD.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyE = new Family();
            familyE.FamilyName = "Family E";
            familyE.AddMember(new Passenger(Passenger.PassengerType.Adult));

            var familyF = new Family();
            familyF.FamilyName = "Family F";
            familyF.AddMember(new Passenger(Passenger.PassengerType.AdultTwoSeats));

            var familyG = new Family();
            familyG.FamilyName = "Family G";
            familyG.AddMember(new Passenger(Passenger.PassengerType.Adult));

            var familyH = new Family();
            familyH.FamilyName = "Family H";
            familyH.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyH.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyH.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyH.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyH.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyI = new Family();
            familyI.FamilyName = "Family I";
            familyI.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyI.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyIA = new Family();
            familyIA.FamilyName = "Family IA";
            familyIA.AddMember(new Passenger(Passenger.PassengerType.Adult));

            var familyJ = new Family { FamilyName = "Family J" };
            familyJ.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyJ.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyJ.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyK = new Family { FamilyName = "Family K" };
            familyK.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyK.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyK.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyL = new Family { FamilyName = "Family L" };
            familyL.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyL.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyL.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyM = new Family { FamilyName = "Family M" };
            familyM.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyM.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyM.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyM.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyN = new Family { FamilyName = "Family N" };
            familyN.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyN.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyN.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyN.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyNA = new Family { FamilyName = "Family NA" };
            familyNA.AddMember(new Passenger(Passenger.PassengerType.Adult));

            var familyNB = new Family { FamilyName = "Family NB" };
            familyNB.AddMember(new Passenger(Passenger.PassengerType.AdultTwoSeats));

            var familyNC = new Family { FamilyName = "Family NC" };
            familyNC.AddMember(new Passenger(Passenger.PassengerType.Adult));


            var familyO = new Family { FamilyName = "Family O" };
            familyO.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyO.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyO.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyO.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyP = new Family { FamilyName = "Family P" };
            familyP.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyP.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyP.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyP.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyPA = new Family { FamilyName = "Family PA" };
            familyPA.AddMember(new Passenger(Passenger.PassengerType.Adult));

            var familyQ = new Family { FamilyName = "Family Q" };
            familyQ.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyQ.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyQ.AddMember(new Passenger(Passenger.PassengerType.Child));

            var familyR = new Family { FamilyName = "Family R" };
            familyR.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyR.AddMember(new Passenger(Passenger.PassengerType.Adult));
            familyR.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyR.AddMember(new Passenger(Passenger.PassengerType.Child));
            familyR.AddMember(new Passenger(Passenger.PassengerType.Child));

            var families = new List<Family> {
                familyA, familyB, familyC , familyD ,
                familyE , familyF , familyG , familyH ,
                familyI ,familyIA, familyJ,familyK ,
                familyL , familyM , familyN , familyNA,
                familyNB,familyNC,familyO , familyP ,
                familyQ , familyR ,
                 };
            #endregion

            // Initialize DP array.
            var dp = new int[families.Count + 1][];
            var chosenFamilies = new List<Family>[families.Count + 1][];
            for (int i = 0; i <= families.Count; i++)
            {
                dp[i] = new int[201];
                chosenFamilies[i] = new List<Family>[201];
                for (int j = 0; j <= 200; j++)
                {
                    dp[i][j] = -1;
                }
            }

            // Apply knapsack algorithm to maximize revenue.
            var result = CalcRevenuMax.CalculerRevenuMaximum(200, families, families.Count, dp, chosenFamilies);
            int maxRevenue = result.Item1;
            var chosen = result.Item2;

            // Print the maximum possible revenue.
            Console.WriteLine($"Maximum possible revenue: {maxRevenue} euros");

            // Print the chosen families.
            Console.WriteLine($"The list of choosen family is : \n");
            foreach (var family in chosen)
            {
                Console.WriteLine(family.FamilyName + "\n");
            }
        }
    }
}
