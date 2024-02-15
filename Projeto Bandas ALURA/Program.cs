// Screen Sound

//C# é extremamente tipada!

// Tipo String:

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

// Criar Listas
/*List<string> listaDasBandas = new List<string> { "Alice in Chains", "Stone Temple Pilots", "Audioslave" };*/

// Dicionário - do tipo String em que os valores são uma lista (no caso, as notas)
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
// Criando as bandas no dicionário com nota
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
// Criando as bandas no dicionário sem nota
bandasRegistradas.Add("The Beatles", new List<int>());




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
    ExibirLogo();
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
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            MostrarMedia();
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
    // Adicionar as bandas ao dicionário, ainda criando uma lista para as notas
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso!");
    // Thread.Sleep é semelhante ao setTimeout!
    Thread.Sleep(2000);
    Console.Clear();
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
    // Keys seriam as BANDAS. É necessário essa especificação se tratando de dicionários
    foreach (string banda in bandasRegistradas.Keys)
    {

        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu");
    Console.ReadKey(); // aceita qualquer tecla;
    Console.Clear();

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

void AvaliarUmaBanda()
{
    // Digite qual banda deseja avaliar
    // Se a banda existir no dicionário >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        // Entre colchetes fica a banda que foi avaliada, após isso é adicionada a essa banda a sua respectiva nota com .Add(variavelDaNota)
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MostrarMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo a média da banda");
    Console.WriteLine("Digite a banda que você deseja ver a média");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        double mediaBanda = bandasRegistradas[nomeDaBanda].Average();
        Console.WriteLine($"\nA média da banda é de {mediaBanda}");
        for (int i = 0; i < bandasRegistradas[nomeDaBanda].Count; i++)
        {
            int nota = bandasRegistradas[nomeDaBanda][i];
            Console.WriteLine($"Nota {i+1}: {nota}");
        };
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("\nA banda não está registrada");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();

