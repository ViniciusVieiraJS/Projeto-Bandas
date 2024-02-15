Dictionary<string, List<int>> notaAluno = new Dictionary<string, List<int>>();



void Menu()
{
    Console.WriteLine("Digite 1 para adicionar um aluno");
    Console.WriteLine("Digite 2 para adicionar uma nota a um aluno existente");
    Console.WriteLine("Digite 3 para ver as médias das notas de um aluno");



    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarAluno();
            break;

        case 2:
            AdicionarNota();
            break;

        case 3:
            MostrarMedia();
            break;

    }

}

void MostrarMedia()
{
    Console.WriteLine("Escreva o nome do aluno");
    string aluno = Console.ReadLine()!;

    if (notaAluno.ContainsKey(aluno))
    {
        List<int> notas = notaAluno[aluno];
        double medias = notas.Average();
        Console.WriteLine($"A média do aluno {aluno} é {medias}");
        Thread.Sleep(3000);
        Menu();

    }
    else
    {
        Console.WriteLine("Aluno não encontrado");
        Thread.Sleep(2000);
        Menu();
    }
}
void RegistrarAluno()
{
    Console.WriteLine("Escreva o nome do aluno");
    string aluno = Console.ReadLine()!;
    notaAluno.Add(aluno, new List<int>());
    Console.WriteLine("Aluno adicionado com sucesso!");
    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

void AdicionarNota()
{
    Console.WriteLine("Escreva o nome do aluno que você queira adicionar uma nota");
    string alunoNota = Console.ReadLine()!;

    if (notaAluno.ContainsKey(alunoNota))
    {
        Console.WriteLine("Escreva a nota do aluno");
        string nota = Console.ReadLine()!;
        int notaNumero = int.Parse(nota);
        notaAluno[alunoNota].Add(notaNumero);
        Console.WriteLine($"Nota {notaNumero} adicionada com sucesso para o aluno {alunoNota}!");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine("Esse aluno não existe");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }
}

Menu();



// DESAFIO 2

Dictionary<string, List<int>> estoque = new Dictionary<string, List<int>>();

void MenuPrincipal()
{
    Console.WriteLine("Digite 1 para registrar um produto");
    Console.WriteLine("Digite 2 para adicionar itens ao estoque de um produto");
    Console.WriteLine("Digite 3 para ver o estoque de um produto");
    string opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarProduto();
            break;
        case 2:
            AdicionarItem();
            break;
        case 3:
            VerEstoque();
            break;

    }

}
void RegistrarProduto()
{
    Console.Clear();
    Console.WriteLine("Digite o nome do produto que deseja registrar");
    string produto = Console.ReadLine()!;
    Console.WriteLine("Produto registrado com sucesso");
    estoque.Add(produto, new List<int>());
    Thread.Sleep(3000);
    Console.Clear();
    MenuPrincipal();
}
void AdicionarItem()
{
    Console.WriteLine("Qual item você deseja adicionar quantidade?");
    string item = Console.ReadLine()!;

    if (estoque.ContainsKey(item))
    {
        Console.Clear();
        Console.WriteLine("Qual a quantidade que você deseja adicionar?");
        string quantidade = Console.ReadLine()!;
        int quantidadeNumerica = int.Parse(quantidade);
        estoque[item].Add(quantidadeNumerica);
        Console.WriteLine("Item adicionado com sucesso");
        Thread.Sleep(3000);
        Console.Clear();
        MenuPrincipal();

    }
    else
    {
        Console.Clear();
        Console.WriteLine("Esse produto não existe no seu estoque");
        Thread.Sleep(3000);
        Console.Clear();
        MenuPrincipal();
    }
}

void VerEstoque()
{
    Console.WriteLine("Insira o item que você deseja ver o estoque");
    string item = Console.ReadLine()!;
    if (estoque.ContainsKey(item))
    {
        List<int> soma = estoque[item];
        double somas = soma.Sum();
        Console.WriteLine($"A quantidade em estoque é {somas}");
        Thread.Sleep(3000);
        Console.Clear();
        MenuPrincipal();
    }
    else
    {
        Console.WriteLine("Esse item não está no seu estoque");
        Thread.Sleep(2000);
        Console.Clear();
        MenuPrincipal();
    }

}
MenuPrincipal();

// DESAFIO 3

Dictionary<string, string> quiz = new Dictionary<string, string>
{
    { "Qual a capital do Brasil?", "Brasília" },
    { "Qual a capital da França?", "Paris" },
    { "Qual a capital de Portugal?", "Lisboa" }
};

int pontuacao = 0;

foreach (var question in quiz)
{
    Console.WriteLine(question.Key);
    string resposta = Console.ReadLine()!;

    if (resposta != question.Value)
    {
        Console.WriteLine("Errou!");
        Thread.Sleep(3000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Acertou!");
        Thread.Sleep(3000);
        Console.Clear();
        pontuacao++;
    }
}

Console.WriteLine($"Você terminou com {pontuacao} ponto(s)");
Thread.Sleep(30000);

// DESAFIO 4

Dictionary<string, string> usuario = new Dictionary<string, string>
{
{"viniv3", "kakaroto123" },
{"vinisa", "fumpy123" }
};

Console.WriteLine("Insira o seu login");
string login = Console.ReadLine()!;
Console.WriteLine("Insira a sua senha");
string senha = Console.ReadLine()!;

if (usuario.ContainsKey(login) && usuario.ContainsValue(senha))
{
    Console.WriteLine("Login realizado com sucesso");
}
else
{
    Console.WriteLine("Cadastro não encontrado");
}

