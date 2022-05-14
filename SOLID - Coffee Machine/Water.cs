using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Liquid of the water type.
    /// </summary>
    class Water : Liquid
    {
        /// <summary>
        /// Inialize an instance of water
        /// </summary>
        /// <param name="quantity">Amount of water.</param>
        public Water(float quantity) : base(quantity, "ml")
        {
        }
    }
}
