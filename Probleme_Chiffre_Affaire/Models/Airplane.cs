using System.Collections.Generic;

namespace Probleme_Chiffre_Affaire.Models
{
    public class Airplane
    {
        public List<Family> Families = new List<Family>();
        public int TotalRevenue => CalculateTotalRevenue();

        public void AddFamily(Family family)
        {
            Families.Add(family);
        }

        private int CalculateTotalRevenue()
        {
            int total = 0;
            foreach (var family in Families)
            {
                total += family.TotalPrice;
            }
            return total;
        }
    }
}
