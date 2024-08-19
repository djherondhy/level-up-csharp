using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuRegistrarUsuario: Menu {
    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Registrar Usuário");
        Console.Write("\nDigite o CPF: ");
        string cpf = Console.ReadLine()!;
        bool usuarioExiste = false;
        foreach (var user in biblioteca.Usuarios) {
            if (user.CPF.Equals(cpf)) {
                usuarioExiste = true; 
            }
        }

        if (usuarioExiste) { Console.WriteLine("\n>> Usuário já existente!"); }
        else {
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine()!;
            biblioteca.AdicionarUsuario(new Usuario(nome, cpf));
        }

        FinalizarOperacao();
    }
}
