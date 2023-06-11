using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Chiffre_Affaire.Models
{
    public class Family
    {
        public string FamilyName { get; set; }
        public List<Passenger> Members = new();
        public int TotalPrice => CalculateTotalPrice();

        public void AddMember(Passenger member)
        {
            Members.Add(member);
        }

        private int CalculateTotalPrice()
        {
            int total = 0;
            foreach (var member in Members)
            {
                total += member.Price;
            }
            return total;
        }
    }
}
