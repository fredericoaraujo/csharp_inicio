using System.Collections;

namespace EstruturaDeDados;
public class Pilha
{
    public static void Imprimir()
    {
        var stack = new Stack();
        // OU
        // var stack = new Stack<string>();
        stack.Push("Primeiro");
        stack.Push("Segundo");
        stack.Push("Terceiro");


        Console.WriteLine("---------------X Lista X----------------");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("---------------X Manual X----------------");
        // Pega o valor corrente
        var nome = stack.Peek();
        Console.WriteLine("Item corrente: " + nome);

        // Remove o valor corrente da fila o item
        nome = stack.Pop();
        Console.WriteLine("Item removido da fila: " + nome);

        nome = stack.Peek();
        Console.WriteLine("Item corrente: " + nome);

        Console.WriteLine("---------------X Lista X----------------");

        foreach (var item in stack)
        {
            Console.WriteLine(item);

        }
    }

}
