
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Salad Recipe App!");

        Recipe recipe = new Recipe();

        // Example usage
        Console.Write("Enter the number of ingredients: ");
        int numIngredients = Convert.ToInt32(Console.ReadLine());
        recipe.AddIngredients(numIngredients);

        Console.Write("Enter the number of steps: ");
        int numSteps = Convert.ToInt32(Console.ReadLine());
        recipe.AddSteps(numSteps);

        // Display recipe
        recipe.DisplayRecipe();

        // Example scaling
        Console.WriteLine("Do you want to scale the recipe? (yes/no)");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
            Console.Write("Enter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            double factor = Convert.ToDouble(Console.ReadLine());
            recipe.ScaleRecipe(factor);
            recipe.DisplayRecipe();
        }

        // Clear data for new recipe
        recipe.ClearRecipe();
        // Ask user if they want to clear all data and enter a new recipe
        Console.WriteLine("\nDo you want to clear all data and enter a new recipe? (yes/no)");
        string clearDataResponse = Console.ReadLine().ToLower();
        if (clearDataResponse == "yes")
        {
            recipe.ClearRecipe();
            Console.WriteLine("All data cleared. Enter a new recipe:");

            // Prompt user to enter a new recipe
            // Example:
            Console.Write("Enter the number of ingredients: ");
            int numIngredient = Convert.ToInt32(Console.ReadLine());
            recipe.AddIngredients(numIngredients);

            Console.Write("Enter the number of steps: ");
            int numStep = Convert.ToInt32(Console.ReadLine());
            recipe.AddSteps(numSteps);

            // Display the new recipe
            recipe.DisplayRecipe();
        }
     
        Console.WriteLine("Thank you for using the Salad Recipe App!");
    }
}
