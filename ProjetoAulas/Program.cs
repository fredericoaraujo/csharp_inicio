// First/FirstOrDefault
// elemento de agregação
// Para pegar o primeiro elemento de uma coleção ou um valor com filtro
// Quando aplicado um filtro que não há valor é gerada a exeção
// exemplo 6 - aplicando um filtro que não retorna elemento aplicando o método FirstOrDefault

int[] numeros = { 10, 6, 5, 50, 15, 2 };
// com sobrecarga de um valor padrão definido
var resultado = numeros.FirstOrDefault(p => p > 100, -99);

Console.WriteLine(resultado);