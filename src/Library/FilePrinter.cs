using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;
//esta clase imprimirá la receta en un archivo de texto, por lo que se crea una clase FilePrinter
//que implementa la interfaz IPrinter y se le agrega el método PrintRecipe que recibe una receta y la imprime en un archivo de texto.
public class FilePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
    }
}