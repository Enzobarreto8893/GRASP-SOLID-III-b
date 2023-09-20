using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;
//la clase ConsolePrinter tomará la responsabilidad de imprimir la receta por consola,
//por lo que se crea una clase ConsolePrinter que implementa la interfaz IPrinter
//y se le agrega el método PrintRecipe que recibe una receta y la imprime por consola.
public class ConsolePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
}