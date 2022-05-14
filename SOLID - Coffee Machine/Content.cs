using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Superclasse for any objebt to be stored in containers.
    /// </summary>
    abstract class Content
    {
        /// <summary>
        /// Amount of content in this instance
        /// </summary>
        private float amount;
        public float Amount
        {
            get { return amount; }
            private set { amount = value; }
        }

        /// <summary>
        /// Unit to measure the content amount in.
        /// </summary>
        private string unit;
        public string Unit
        {
            get { return unit; }
            private set { unit = value; }
        }

        /// <summary>
        /// Base constructor of the content superclass
        /// </summary>
        /// <param name="quantity">Amount of content inialized with the content</param>
        /// <param name="unitOfMeasure">Unit to measure the content in</param>
        public Content(float quantity, string unitOfMeasure)
        {
            Amount = quantity;
            Unit = unitOfMeasure;
        }
    }
}
