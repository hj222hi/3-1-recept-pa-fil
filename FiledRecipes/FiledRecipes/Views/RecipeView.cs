﻿using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.Clear();

            //Skriv ut receptets namn i en header
            Header = recipe.Name;
            ShowHeaderPanel();

            //Skriver ut ingredienserna
            Console.WriteLine("\nIngredienser\n=============");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }

            //Skriver ut instruktionerna
            Console.WriteLine("\nGör så här\n==========");
            int i = 0;

            foreach (var instruction in recipe.Instructions)
            {
                Console.WriteLine(++i);
                Console.WriteLine("{0}\n", instruction);
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            //Skriv ut alla recept använder den tidigare metoden i denna klass
            //Tryck ner en tangent för att visa nästa recept
            foreach (var recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }
}