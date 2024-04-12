Salad Recipe App

The Salad Recipe App is a command-line application that allows users to enter and store the details of a salad recipe. It provides functionality for adding ingredients and steps, displaying the recipe, scaling quantities, resetting quantities, and clearing data for a new recipe.

How to Use

Clone or download the repository to your local machine.
Open the solution in Visual Studio.
Build and run the project.
Follow the prompts to enter the details of your salad recipe:
Enter the number of ingredients.
For each ingredient, enter the name, quantity, and unit of measurement.
Enter the number of steps.
For each step, enter a description of what to do.
Once the recipe is entered, it will be displayed in a neat format.
Optionally, you can scale the recipe by a factor of 0.5 (half), 2 (double), or 3 (triple).
You can also reset the quantities to the original values or clear all data to enter a new recipe.
Classes

Ingredient: Represents an ingredient with properties for name, quantity, and unit of measurement.
RecipeStep: Represents a step in the recipe with a description of what to do.
Recipe: Abstract class representing a recipe. Contains methods for managing ingredients, steps, and displaying the recipe.
Program: Contains the entry point and main method for the application.
Important Notes

The application does not persist user data between runs. Data is stored in memory only while the application is running.
The code follows internationally acceptable coding standards and includes comprehensive comments explaining variable names, methods, and logic.
The Recipe class demonstrates inheritance, encapsulation, abstraction, and polymorphism.
