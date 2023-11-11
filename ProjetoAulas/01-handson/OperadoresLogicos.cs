namespace OperadoresLogicos;
public class Main
{

    public static void Imprimir()
    {
        Console.WriteLine("Tabela Verdade");

        bool verdadeiro = true;
        bool falso = false;

        var resultadoE = verdadeiro && falso;
        Console.Write("verdadeiro && falso = ");
        Console.WriteLine(resultadoE);

        var resultadoOu = verdadeiro || falso;
        Console.Write("verdadeiro || falso = ");
        Console.WriteLine(resultadoOu);

        Console.Write("!verdadeiro = ");
        Console.WriteLine(!verdadeiro);

        Console.Write("!falso = ");
        Console.WriteLine(!falso);
    }

}
