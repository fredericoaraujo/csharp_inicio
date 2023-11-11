namespace Variaveis;
public class Main
{

    public static void Imprimir()
    {
        // Toda instrução em C# (C sharp) deve terminar com o sinal de ponto-e-vírgula (;)

        // imprimir Meu primeiro programa no console
        // O comando Console.WriteLine(...) sempre vai imprimir em nova linha
        // Para imprimir na mesma linha usa-se o comando Console.Write(...)
        Console.WriteLine("Meu primeiro programa");

        // variável inteira
        int idade = 18;
        Console.WriteLine(idade);

        // Variável para nomes, endereço e etc utilizamos a cadeia de caracteres string
        // Deve estar sempre entre aspas duplas -> "valor"
        string nomePessoa = "Rafael Aalmeida";
        Console.WriteLine(nomePessoa);

        // Em C# todos os valores como ponto flutuantes (fração) são entendidos como do tipo double como padrão
        double valorDouble = 200.99;
        // Para decimal temos que colocar a letra "m" no final
        decimal valorDecimal = 200.99m;
        // Para float temos que colocar a letra "f" no final
        float valorFloat = 200.99f;

        Console.WriteLine(valorDouble);
        Console.WriteLine(valorDecimal);
        Console.WriteLine(valorFloat);

        // Tipo de variável coringa
        // A palavra reservada var é utilizada para declarar uma variável e assume o tipo do valor atribuído a ela
        var novaIdade = 34; // assumirá o tipo int (Int32)
        Console.WriteLine(novaIdade);

        // para o tipo char tem que atribuir o valor com aspas simples ('a') e só aceita 1 caracter
        char flag = 'Y';
        Console.WriteLine(flag);

        // o tipo booleano (bool) são aceitos apenas os valores true ou false
        bool ativo = true; // bool ativo = false;
        Console.WriteLine(ativo);


    }

}
