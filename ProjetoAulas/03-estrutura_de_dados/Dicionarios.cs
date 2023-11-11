namespace EstruturaDeDados;
public class Dicionários
{

    public static void Imprimir()
    {
        // Dicionários

        // inicializando um dicionário
        var linguas = new Dictionary<string, string>() { { "en", "English" } };

        // método de adição de chaves e valores
        linguas["es"] = "Spanish";
        linguas.Add("pt", "Portuguese");

        foreach (var item in linguas)
        {
            Console.WriteLine(item.Key + " => " + item.Value);
        }

        linguas["pt-BR"] = "Brazilian Portuguese";

        // Método de recuperação pela chave
        Console.WriteLine(linguas["pt-BR"]);
    }

}
