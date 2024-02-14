/*//// EXERCÍCIO 1

//void CalculosMatematicos()
//{
//    Console.WriteLine("Digite os números");
//    float a = float.Parse(Console.ReadLine());
//    Console.WriteLine($"O número digitado foi {a}");
//    Thread.Sleep(1000);
//    Console.WriteLine("Digite o segundo número");
//    float b = float.Parse(Console.ReadLine());
//    Console.WriteLine($"O número digitado foi {b}");


//    float soma = a + b;
//    float multiplicacao = a * b;
//    float divisao = a / b;
//    float subtracao = a - b;

//    Console.WriteLine($"A soma entre os números {a} e {b} é {soma}");
//    Console.WriteLine($"A subtração entre os números {a} e {b} é {subtracao}");
//    Console.WriteLine($"A multiplicação entre os números {a} e {b} é {multiplicacao}");
//    Console.WriteLine($"A divisao entre os números {a} e {b} é {divisao}");


//}

//CalculosMatematicos();

// EXERCÍCIO 2

//using System;

//List<string> bandasLegais = new List<string> {"Linkin Park", "Nirvana" };

//void RegistrarBandas() {

//    Console.WriteLine("Adicione uma banda");
//    string nomeBanda = Console.ReadLine()!;
//    bandasLegais.Add(nomeBanda);
//    Console.WriteLine("Essas são suas bandas favoritas");
//    foreach (string banda in bandasLegais) 
//    {
//      Console.WriteLine($"Banda: {banda}");
//    }
//}

//void listarFor()
//{
//    for (int i = 0; i < bandasLegais.Count; i++) {
//        string nomeBanda = bandasLegais[i];
//        Console.WriteLine(nomeBanda);

//    }
//}


//    Console.WriteLine("Digite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para ver as bandas");
//    string numero = Console.ReadLine()!;
//    int numeroEscolhido = int.Parse(numero);


//if (numeroEscolhido == 1)
//{
//    RegistrarBandas();
//}
//else
//{
//    listarFor();
//}

// EXERCÍCIO 4

//List<int> numerosInteiros = new List <int> { 1, 3, 5, 7, 8, 9 };
//int soma = 0;
//for (int i = 0; i < numerosInteiros.Count; i++)
//{
//    int numeroAtual = numerosInteiros[i];
//    soma += numeroAtual;
//}

//Console.WriteLine(soma);

// FAÇA COMO EU FIZ

List<int> numerosInteiros = new List<int> { 1, 2, 3, 5, 7, 10, 11, 14, 15, 20 };

for (int i = 0; i < numerosInteiros.Count; i++)
{
    int numeroAtual = numerosInteiros[i];
    if (numeroAtual % 2 == 0)
        Console.WriteLine(numeroAtual);
}


foreach (int i in numerosInteiros)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
}
*/