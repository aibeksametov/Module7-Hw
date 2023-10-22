using System;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        private string tankName;
        private int ammunition;
        private int armor;
        private int maneuverability;

        public Tank(string name)
        {
            Random random = new Random();
            tankName = name;
            ammunition = random.Next(101);
            armor = random.Next(101);
            maneuverability = random.Next(101);
        }

        public string GetTankInfo()
        {
            return $"{tankName}: Ammo: {ammunition}%, Armor: {armor}%, Maneuverability: {maneuverability}%";
        }

        public static bool operator ^(Tank tank1, Tank tank2)
        {
            int pointsTank1 = 0;
            int pointsTank2 = 0;

            if (tank1.ammunition > tank2.ammunition)
                pointsTank1++;
            else if (tank1.ammunition < tank2.ammunition)
                pointsTank2++;

            if (tank1.armor > tank2.armor)
                pointsTank1++;
            else if (tank1.armor < tank2.armor)
                pointsTank2++;

            if (tank1.maneuverability > tank2.maneuverability)
                pointsTank1++;
            else if (tank1.maneuverability < tank2.maneuverability)
                pointsTank2++;

            return pointsTank1 > pointsTank2;
        }
    }
}