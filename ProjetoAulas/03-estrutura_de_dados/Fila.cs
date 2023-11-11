using System.Collections;

namespace EstruturaDeDados;
public class Fila
{
    public static void Imprimir()
    {

        // var queue = new Queue();
        // OU
        var queue = new Queue<string>();
        queue.Enqueue("Primeiro");
        queue.Enqueue("Segundo");
        queue.Enqueue("Terceiro");

        // Pega o valor corrente
        var nome = queue.Peek();
        Console.WriteLine("Item corrente: " + nome);

        // Remove o valor corrente da fila o item
        nome = queue.Dequeue();
        Console.WriteLine("Item removido da fila: " + nome);

        nome = queue.Peek();
        Console.WriteLine("Item corrente: " + nome);

        Console.WriteLine("---------------X Lista X----------------");

        foreach (var item in queue)
        {
            Console.WriteLine(item);

        }
    }

}
