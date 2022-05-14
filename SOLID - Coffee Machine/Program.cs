using System;
using SOLID___Coffee_Machine;

CoffeeMachine coffeeMachine = new CoffeeMachine(500, 200);

CoffeeMachineMenu();

void CoffeeMachineMenu()
{
    bool looper = true;
    while (looper)
    {
        Console.Clear();
        Console.WriteLine("1. Turn on coffee Machine");
        Console.WriteLine("2. Add water");
        Console.WriteLine("3. Add coffee beans");

        switch (Console.ReadKey(true).KeyChar)
        {
            case '1':
                TurnOnCoffeMachine();
                break;
            case '2':
                AddWater();
                break;
            case '3':
                AddCoffeeBeans();
                break;
        }

        PressToContinue();
    }
}

void TurnOnCoffeMachine()
{
    Console.Clear();
    try
    {
        Console.WriteLine("Coffee brewing...");
        coffeeMachine.TurnOn();
        CoffeeBrewed();
    }
    catch (Exception ex)
    {
        Console.Clear();
        Console.WriteLine(ex.ToString());
    }
}

void CoffeeBrewed()
{
    Console.WriteLine("The coffee maching brewed {0} {1} of coffee",
        coffeeMachine.CoffeePot.Containing.Amount,
        coffeeMachine.CoffeePot.Containing.Unit);
}

void AddWater()
{
    bool looper = true;
    while (looper)
    {
        Console.Clear();
        Console.WriteLine("1. How many cups?");
        string input = Console.ReadLine();
        if (IsDigitsOnly(input) && input != null)
        {
            int cups = Convert.ToInt16(input);
            try
            {
                coffeeMachine.FillWaterContainer(cups);
                ContainerUpdated(coffeeMachine.WaterContainer);
                looper = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                PressToContinue();
            }
        }

    }
}

void AddCoffeeBeans()
{
    bool looper = true;
    while (looper)
    {
        Console.Clear();
        Console.WriteLine("1. How many cups?");
        string input = Console.ReadLine();
        if (IsDigitsOnly(input) && input != null)
        {
            int cups = Convert.ToInt16(input);
            try
            {
                coffeeMachine.FillCoffeeContainer(cups);
                ContainerUpdated(coffeeMachine.CoffeeContainer);
                looper = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                PressToContinue();
            }
        }

    }
}

/// <summary>
/// Checks if a string only contains digit chars
/// </summary>
/// <param name="str">String to test</param>
/// <returns>True if only digits</returns>
bool IsDigitsOnly(string str)
{
    foreach (char c in str)
    {
        if (c < '0' || c > '9')
            return false;
    }

    return true;
}

void ContainerUpdated(Container container)
{
    Console.WriteLine("Added {0} {1} to the container",
                    container.Containing.Amount,
                    container.Containing.Unit);
}

/// <summary>
/// Prompts the user to press any button to continue.
/// </summary>
void PressToContinue()
{
    Console.WriteLine("\nPress any button to continue..");
    Console.ReadKey(true);
}