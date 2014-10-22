using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("Recipes.txt"))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Fel inträffade vid läsning av textfil.");
            }
    }
    }
}
