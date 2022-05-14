using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Superclass for all liquid classes.
    /// </summary>
    abstract class Liquid : Content
    {
        /// <summary>
        /// Tempeture of the liquid content.
        /// </summary>
        private float tempeture;
        public float Tempeture
        {
            get { return tempeture; }
            private set { tempeture = value; }
        }

        public Liquid(float quantity, string unitOfMeasure) : base(quantity, unitOfMeasure)
        {

        }

        /// <summary>
        /// Changes the tempeture of the liquid
        /// </summary>
        /// <param name="changeInTemp">The amount to change to tempeture by.</param>
        public void ChangeTempeture(float changeInTemp)
        {
            Tempeture += changeInTemp;
        }

    }
}
