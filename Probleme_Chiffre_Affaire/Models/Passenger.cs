using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Chiffre_Affaire.Models
{
    public class Passenger
    {
        public enum PassengerType { Adult, Child, AdultTwoSeats };
        public PassengerType Type;
        public int Price;

        public Passenger(PassengerType type)
        {
            Type = type;
            switch (type)
            {
                case PassengerType.Adult:
                    Price = 250;
                    break;
                case PassengerType.Child:
                    Price = 150;
                    break;
                case PassengerType.AdultTwoSeats:
                    Price = 500;
                    break;
            }
        }
    }
}
