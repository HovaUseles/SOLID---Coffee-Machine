using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Superclass for all appliances. Can turn on and off.
    /// </summary>
    abstract class Appliance
    {
        /// <summary>
        /// Does the device have power
        /// </summary>
        private bool hasPower;
        public bool HasPower
        {
            get { return hasPower; }
            private set { hasPower = value; }
        }

        /// <summary>
        /// Base constructor for the appliance class. Power is off on construction.
        /// </summary>
        public Appliance()
        {
            hasPower = false;
        }

        /// <summary>
        /// Turns on power for the appliance
        /// </summary>
        public virtual void TurnOn()
        {
            HasPower = true;
        }

        /// <summary>
        /// Turns of power to the appliance
        /// </summary>
        public virtual void TurnOff()
        {
            HasPower = false;
        }


    }
}
