using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuListarUsuarios:Menu {

    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Lista de Usuários\n");
        if (biblioteca.Usuarios.Count > 0) {
            biblioteca.ExibirListaUsuarios();
        }
        else { Console.WriteLine("\n>> Nenhum usuário registrado!"); }
        
        FinalizarOperacao();
    }

}
