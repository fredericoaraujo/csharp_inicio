namespace Constante;
public class Main
{

    public static void Imprimir()
    {
        // Para definir uma constante deve-se utilizar a palavra reservada const
        const string descricao = "Curso de CSharp";
        Console.WriteLine(descricao);

        // Quando a gente tenta alterar o valor de uma constante é informado um erro
        // descricao = "Novo Curso";
        // Console.WriteLine(descricao);
    }

}
