/*Dictionary<string, List<int>> notaAluno =  new Dictionary<string, List<int>>(); 



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

*/

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
    }
}