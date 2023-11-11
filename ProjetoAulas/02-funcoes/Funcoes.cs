namespace Funcoes;
public class Main
{

    public static void Imprimir()
    {
        var main = new Main();
        string nome = main.NomeCompleto();
        Console.WriteLine(nome);

        int resultado = main.Soma(2, 3);
        Console.WriteLine(resultado);

        var pessoa = main.CriarPessoa("Maria", 40);
        Console.WriteLine(pessoa);
    }

    // função simples
    // string -> tipo de valor a ser retornado
    // NomeCompleto -> nome da função
    // return -> comando para retornar algum valor
    // "Rafael Almeida" -> valor da string retornada
    string NomeCompleto()
    {
        return "Rafael Almeida";
    }



    // funções com parametros
    int Soma(int num1, int num2)
    {
        return num1 + num2;
    }



    string CriarPessoa(string nome, int idade)
    {
        return "Olá, sou " + nome + " e tenho " + idade + " anos";
    }



}
