﻿// Screen Sound

//C# é extremamente tipada!

// Tipo String:

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

// Criar Listas
List<string> listaDasBandas = new List<string> { "Alice in Chains", "Stone Temple Pilots", "Audioslave" };



// toda instrução precisa terminar com ;

// Variáveis usar o padrão CamelCase

// DESAFIO 1:

string curso = "Curso";

Console.WriteLine(curso);

// Criar uma Função
// Funções usam padrão PascalCase (primeira letra maiúscula)


void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

// Criar um menu de opções

void ExibirOpcoesDoMenu()
{

    // \n dá um espaço de uma linha
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    // Fazer a pergunta
    // Usar Write ao invés de WriteLine para deixar na mesma linha

    Console.Write("\nDigite a sua opção: ");

    // Recuperar o valor que a pessoa digitou
    // Console.ReadLine
    // Armazenar a entrada
    // ! = faz o ReadLine não aceitar valores nulos

    string opcaoEscolhida = Console.ReadLine()!;
    //int.Parse = função parse que tenta converter uma string para int
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    // SWITCH

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        // Se não cair em nenhuma das situações listadas, cai no default
        default:
            Console.WriteLine("Inválido");
            break;

    }

}
void RegistrarBanda()
{

    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");

    Console.Write("Digite o nome da banda que você quer registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    // Thread.Sleep é semelhante ao setTimeout!
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{

    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    // Percorrendo a lista
    //for (int i = 0; i < listaDasBandas.Count; i++) // semelhante ao JS, o count ele "conta"
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");

    //}

    // foreach = para cada elemento da lista
    // primeiro você representa a váriavel | in | depois declarar a variável que representa a lista
    foreach (string banda in listaDasBandas)
    {

        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu");
    Console.ReadKey(); // aceita qualquer tecla;
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();



}// Aqui a gente criou uma função para padronizar os títulos das opções
// O parâmetro "titulo" é referenciado aonde a função é chamada
void ExibirTituloDaOpcao(string titulo)
{
    // Aqui a gente define uma quantidade de letras, no caso para o asterisco
    int quantidadeLetras = titulo.Length;
    // aqui a gente tipa uma string vazia para definir os astericos, padleft para ele começar da esquerda
    // dentro dos parentêses, está 'quantidadeLetras' para ver a quantidade de asteriscos que será escrito (será igual ao length do título), e '*' para definir o caractere a ser mostrado, no caso asteriscos
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    // e finalmente aqui a gente define o que será mostrado ao chamar a função
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirLogo();
ExibirOpcoesDoMenu();
