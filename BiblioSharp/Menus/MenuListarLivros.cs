using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuListarLivros : Menu {

    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Lista de Livros Disponíveis\n");
        if (biblioteca.Livros.Count > 0) {
            biblioteca.ExibirLivrosDisponiveis();
        }
        else { Console.WriteLine("\n>> Nenhum usuário registrado!"); }
        
        FinalizarOperacao();
    }

}
