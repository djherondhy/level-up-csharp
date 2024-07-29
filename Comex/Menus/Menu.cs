
using Comex.Models;

namespace Comex.Menus; 
internal class Menu {

    public void ExibirTitulo(string titulo) {
        int tamTitulo = titulo.Length;
        string asteriscos = "" + string.Empty.PadRight(tamTitulo, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos);
        Console.WriteLine("");
    }

    public virtual void Executar(List<Produto> produtos) {
       Console.Clear();
                       
    }
}
