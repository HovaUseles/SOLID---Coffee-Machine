using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Liquid of the coffee type.
    /// </summary>
    internal class Coffee : Liquid
    {
        /// <summary>
        /// strength of taste in the Coffee
        /// </summary>
        private string strength;
        public string Stregnth
        {
            get { return strength; }
            private set { strength = value; }
        }

        /// <summary>
        /// Inialize an instance of coffee
        /// </summary>
        /// <param name="quantity">Amount of coffee.</param>
        /// <param name="unitOfMeasure">The unit to measure the amount in.</param>
        /// <param name="tasteStrength">Strength of the coffee.</param>
        public Coffee(float quantity, string tasteStrength ) : base(quantity, "ml")
        {
            strength = tasteStrength;
        }
    }
}
