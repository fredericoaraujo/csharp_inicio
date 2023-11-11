using System.Collections;

namespace EstruturaDeDados;
public class EstruturaDeDadosArrayList
{

    public static void Imprimir()
    {

        var arrayList = new ArrayList();
        arrayList.Add(1); // indice 0
        arrayList.Add("Rafael"); // indice 1
        arrayList.Add(true); // indice 2

        Console.WriteLine(arrayList[1]);

        // O foreach é uma estrutura de controle para percorrer a coleção
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Para remover 1 item da lista
        // arrayList.RemoveAt(indice);
        arrayList.RemoveAt(1);

        // Para apagar os dados da minha lista tem 2 formas
        // 1 - atribuir uma nova instância de ArrayList
        // arrayList = new ArrayList();
        // 2 - Utilizar o método de instância Clear
        arrayList.Clear();

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

    }

}