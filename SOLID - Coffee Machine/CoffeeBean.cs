using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Content of the type coffeebean
    /// </summary>
    internal class CoffeeBean : Content
    {
        /// <summary>
        /// Strenth of the coffeebean
        /// </summary>
        private int strenth;
        public int Strength
        {
            get { return strenth; }
            private set { strenth = value; }
        }

        /// <summary>
        /// Inializes an instance of the coffeebean, with amount and strength of the bean.
        /// </summary>
        /// <param name="quantity">How many grams of the coffeebean</param>
        /// <param name="tasteStrength">Strength of the bean.</param>
        public CoffeeBean(float quantity, int tasteStrength) : base(quantity, "g")
        {
            Strength = tasteStrength;
        }


    }
}
