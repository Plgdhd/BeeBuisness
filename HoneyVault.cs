using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;

namespace BeeBuisness
{
    internal class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = .19f;
        const float LOW_LEVEL_WARNING = 10f;
        private float honey = 25f;
        private float nectar = 100f;

        void ConvertNectarToHoney(float amount)
        {
            if (amount > nectar)
            {
                honey += nectar * NECTAR_CONVERSION_RATIO;
                nectar = 0f;
            }
            else
            {
                nectar -= amount;
                honey += amount * NECTAR_CONVERSION_RATIO;
            }
        }

        public bool ConsumeHoney(float amount)
        {
            if (amount >= honey)
            {
                honey -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        void CollectNectar(float amount)
        {
            if (amount >= 0f)
            {
                honey += amount;
            }
        }

        public string StatusReport
        {
            get
            {
                string status = $" {honey: 0.0} units of honey\n" + $"{nectar: 0.0} units of nectar\n";
                string warnings = "";
                if (honey < LOW_LEVEL_WARNING)
                {
                    warnings += "\n LOW HONEY -- ADD A HONEY MANIFACTURER";
                }
                if (nectar < LOW_LEVEL_WARNING)
                {
                    warnings += "\n LOW NECRAR -- ADD A NECTAR COLLECTOR";
                }
                return status + warnings;
            }
        }
    }
}
