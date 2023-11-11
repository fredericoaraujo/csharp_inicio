namespace EstruturaDeDados;
public class ArrayTipado
{

    public static void Imprimir()
    {
        // Array Tipado

        // atribuição via instancia
        var arrayTipadoNumero = new int[3] { 1, 2, 3 };

        foreach (int item in arrayTipadoNumero)
        {
            Console.WriteLine(item);
        }


        // atribuição tardia
        int[] arrayTipadoNumero2 = new int[3];
        arrayTipadoNumero2[0] = 1;
        arrayTipadoNumero2[1] = 5;
        arrayTipadoNumero2[2] = 10;

        foreach (int item in arrayTipadoNumero2)
        {
            Console.WriteLine(item);
        }
    }

}
