using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Coffee_Machine
{
    /// <summary>
    /// Brews coffee with water and coffee beans.
    /// </summary>
    internal class CoffeeMachine : Appliance, IHeatable
    {
        /// <summary>
        /// Container that holds the water.
        /// </summary>
        private Container waterContainer;
        public Container WaterContainer
        {
            get { return waterContainer; }
            private set { waterContainer = value; }
        }

        /// <summary>
        /// Container that holds coffee beans
        /// </summary>
        private Container coffeeContainer;
        public Container CoffeeContainer
        {
            get { return coffeeContainer; }
            private set { coffeeContainer = value; }
        }

        /// <summary>
        /// Container that holds the brewed coffee
        /// </summary>
        private Container coffeePot;
        public Container MyProperty
        {
            get { return coffeePot; }
            private set { coffeePot = value; }
        }

        /// <summary>
        /// Time it takes the coffee machine to brew coffee
        /// </summary>
        private int brewTime;
        public int BrewTime
        {
            get { return brewTime; }
            set { brewTime = value; }
        }

        /// <summary>
        /// Amount the coffee machine considers one cup
        /// </summary>
        private float cupSize;
        public float CupSize
        {
            get { return cupSize; }
            set { cupSize = value; }
        }

        /// <summary>
        /// Inializes an instance of the CoffeeMachine class, with a waterContainer, coffeeContainer and coffeePot. 
        /// Sets arguments time to brew and amountPerCup.
        /// </summary>
        /// <param name="timeToBrew">Time it takes the machine to brew one cup of coffee.</param>
        /// <param name="amountPerCup">The amount per cups the machine calculates from.</param>
        public CoffeeMachine(int timeToBrew, float amountPerCup)
        {
            BrewTime = timeToBrew;
            CupSize = amountPerCup;
            waterContainer = new Container(1000); // Can hold 1000 ml of water
            coffeeContainer = new Container(200); // Can hold 200 g of coffee beans
            coffeePot = new Container(1000); // Can hold 1000 ml of coffee
        }

        /// <summary>
        /// Brews the coffee.
        /// </summary>
        /// <returns>The coffeepot of coffee</returns>
        /// <exception cref="Exception">If no water in the watercontainer</exception>
        public Container Brew()
        {
            if (waterContainer.Containing != null)
            {
                float amount = waterContainer.Containing.Amount;
                string strength;
                try
                {
                    strength = CalcCoffeeStrength();
                }
                catch (NotImplementedException)
                {
                    strength = "medium";
                }

                Coffee coffee = new Coffee(amount, strength);
                coffeePot.Fill(coffee);
                return coffeePot;
            }
            else
            {
                throw new Exception("No water in container");
            }
        }

        public override void TurnOn()
        {
            base.TurnOn();
            try
            {
                HeatLiquid();
                Brew();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }
        /// <summary>
        /// Heats up liquid in the waterContainer
        /// </summary>
        public void HeatLiquid()
        {
            if (waterContainer.Containing != null)
            {
                Water water = (Water)waterContainer.Containing;
                float tempChange = 1.4f;
                while (water.Tempeture < 92)
                {
                    water.ChangeTempeture(tempChange);
                    Thread.Sleep(400);
                }
            }
            else
            {
                throw new Exception("No water in container");
            }
        }

        /// <summary>
        /// Fills the water container with water equal to the number of cups.
        /// </summary>
        /// <param name="cups">Amount of cups added to coffee machine water container.</param>
        public void FillWaterContainer(int cups)
        {
            float waterAmount = (float)CupSize * cups;
            Water water = new Water(waterAmount);
            try
            {
                waterContainer.Fill(water);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Fills the coffee container with an amount coffee beans needed for the number of cups.
        /// </summary>
        /// <param name="cups">Controls the amount of coffee beans added to coffee machine coffee container.</param>
        public void FillCoffeeContainer(int cups)
        {
            float coffeeAmount = cups * 16;
            CoffeeBean beans = new CoffeeBean(coffeeAmount, 3);
            try
            {
                coffeeContainer.Fill(beans);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Calculates the strength of the coffee
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string CalcCoffeeStrength()
        {
            throw new NotImplementedException();
        }
    }
}
