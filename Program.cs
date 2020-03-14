﻿using System;
using GasolineraKalum.Controllers;
using GasolineraKalum.Entities;
using GasolineraKalum.Menu;
using static GasolineraKalum.Util.Printer;
using static System.Console;
namespace GasolineraKalum
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            WriteTitle("Gasolinera Kalum");
            new MenuPrincipal().MostrarMenu(); 
            PresionarEnter();
        
        }
    }
}
