
// Abstract class representing a recipe
public class Recipe
{
    // Encapsulation: private fields to hold ingredients and steps
    private Ingredient[] ingredients;
    private RecipeStep[] steps;


    // Constructor to initialize ingredients and steps arrays
    public Recipe()
    {
        ingredients = new Ingredient[0];
        steps = new RecipeStep[0];
    }

    // Method to add ingredients to the recipe
    public void AddIngredients(int numIngredients)
    {
        ingredients = new Ingredient[numIngredients];
        for (int i = 0; i < numIngredients; i++)
        {
            Console.Write($"Enter name of ingredient {i + 1}: ");
            string name = Console.ReadLine();
            Console.Write($"Enter quantity of {name}: ");
            double quantity = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter unit of measurement for {name}: ");
            string unit = Console.ReadLine();

            ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }
    }

    // Method to add steps to the recipe
    public void AddSteps(int numSteps)
    {
        steps = new RecipeStep[numSteps];
        for (int i = 0; i < numSteps; i++)
        {
            Console.Write($"Enter description for step {i + 1}: ");
            string description = Console.ReadLine();

            steps[i] = new RecipeStep { Description = description };
        }
    }

    // Abstract method to display the recipe
    public void DisplayRecipe()
    {
        Console.WriteLine("Recipe:");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
        }

        Console.WriteLine("\nSteps:");
        for (int i = 0; i < steps.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {steps[i].Description}");
        }
    }


    // Virtual method to scale the recipe
    public void ScaleRecipe(double factor)
    {
        foreach (var ingredient in ingredients)
        {
            ingredient.Quantity *= factor;
        }
    }
    // Method to clear recipe data
    public void ClearRecipe()
    {
        ingredients = new Ingredient[0];
        steps = new RecipeStep[0];
    }

    // Virtual method to reset ingredient quantities
    public void ResetQuantities()
    {
        // Reset ingredient quantities to original values
    }



}
