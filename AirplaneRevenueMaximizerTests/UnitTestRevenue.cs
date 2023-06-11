using Microsoft.VisualStudio.TestTools.UnitTesting;
using Probleme_Chiffre_Affaire.Helper;
using Probleme_Chiffre_Affaire.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace AirplaneRevenueMaximizerTests
{
    public class UnitTestRevenue
    {
        [TestClass]
        public class ProgramTests
        {
            [TestMethod]
            public void TestRevenue()
            {
                // Arrange
                var family1 = new Family();
                family1.AddMember(new Passenger(Passenger.PassengerType.Adult));
                family1.AddMember(new Passenger(Passenger.PassengerType.Child));
                family1.AddMember(new Passenger(Passenger.PassengerType.Child));

                var family2 = new Family();
                family2.AddMember(new Passenger(Passenger.PassengerType.AdultTwoSeats));

                var family3 = new Family();
                family3.AddMember(new Passenger(Passenger.PassengerType.Adult));
                family3.AddMember(new Passenger(Passenger.PassengerType.Child));

                var families = new List<Family> { family1, family2, family3 };

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

                // Act
                var result = CalcRevenuMax.CalculerRevenuMaximum(200, families, families.Count, dp, chosenFamilies);

                // Assert
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(1150, result.Item1); // Expected maximum revenue
                CollectionAssert.AreEquivalent(families, result.Item2); // Expected chosen families
            }
        }
    }
}
