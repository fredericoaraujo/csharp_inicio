using System.Collections;

namespace EstruturaDeDados;
public class ListaGenerica
{

    public static void Imprimir()
    {

        var lista = new List<string>(2) { "Rafael", "Almeida" };
        // adicionando e redimensionando a lista
        lista.Add("João");
        lista.Add("José");
        lista.Add("Maria");

        // pegar um item da lista por um índice
        string nome = lista[1];
        Console.WriteLine(nome);

        Console.WriteLine("----------------------------");

        // percorrer a lista toda
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------------------");

        // apagar 1 item da lista
        lista.RemoveAt(1);
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("----------------------------");
        // limpando a lista
        lista.Clear();
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

    }

}
