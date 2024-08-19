using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class Menu {
    public virtual void Executar(Biblioteca biblioteca) {
        Console.Clear();
    }

    public void FinalizarOperacao() {
        Console.WriteLine("\n\n>> Digite uma tecla para retornar ao menu!");
        Console.ReadKey();
        Console.Clear();
        
    }
}
