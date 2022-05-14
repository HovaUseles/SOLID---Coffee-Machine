using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Holds an amount of content.
    /// </summary>
    internal class Container
    {
        /// <summary>
        /// Max amount the container can hold.
        /// </summary>
        private float capacity;
        public float Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        /// <summary>
        /// What the container holds
        /// </summary>
        private Content? containing;
        public Content? Containing
        {
            get { return containing; }
            set { containing = value; }
        }

        /// <summary>
        /// Inialize an instance of container with a max capacity
        /// </summary>
        /// <param name="cap"></param>
        public Container(float cap)
        {
            Capacity = cap;
        }

        /// <summary>
        /// Fills the container with some content. Can only hold one instance of content at any time.
        /// </summary>
        /// <param name="content"></param>
        public void Fill(Content content)
        {
            if (containing == null)
            {
                if (content.Amount < Capacity)
                {
                    containing = content;
                }
                else
                {
                    throw new Exception($"Container not large enough. \nCapacity: {capacity}\nAmount: {content.Amount}");
                }
            }
            else
            {
                throw new Exception("Container already filled");
            }
        }

        /// <summary>
        /// Empties the container.
        /// </summary>
        public Content Empty()
        {
            Content temp = containing;
            containing = null;
            return temp;
        }

    }
}
