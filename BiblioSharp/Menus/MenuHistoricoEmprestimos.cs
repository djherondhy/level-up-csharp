using BiblioSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSharp.Menus; 
internal class MenuHistoricoEmprestimos : Menu {

    public override void Executar(Biblioteca biblioteca) {
        base.Executar(biblioteca);
        Console.WriteLine(">> Histórico de Empréstimos\n");  

        Console.Write("\nDigite o CPF: ");
        string cpf = Console.ReadLine()!;
        Usuario usuario = null;
        foreach (var user in biblioteca.Usuarios) {
            if (user.CPF.Equals(cpf)) {
                usuario = user;
            }
        }

        if (usuario != null) {
            usuario.ExibirHistorico(); 
        }
        else {
            Console.WriteLine("\n>> Usuário não registrado!");
        }

        FinalizarOperacao();
    }

}
