//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library;

//esta será la clase IPrinter, que tendrá un método PrintRecipe que recibe una receta y la imprime.
//Esta interfaz será implementada por las clases ConsolePrinter y FilePrinter.
public interface IPrinter
{
    void PrintRecipe(Recipe recipe);
}

