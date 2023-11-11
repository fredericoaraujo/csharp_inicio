namespace OperadoresRelacionais;
public class Main
{

    public static void Imprimir()
    {
        int num1 = 2;
        int num2 = 3;

        bool igual = num1 == num2;
        Console.WriteLine(igual);

        bool maior = num1 > num2;
        Console.WriteLine(maior);

        bool menor = num1 < num2;
        Console.WriteLine(menor);

        bool maiorIgual = num1 >= num2;
        Console.WriteLine(maiorIgual);

        bool menorIgual = num1 <= num2;
        Console.WriteLine(menorIgual);

        bool diferente = num1 != num2;
        Console.WriteLine(diferente);
    }

}
