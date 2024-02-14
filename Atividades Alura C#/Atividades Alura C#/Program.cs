// ATIVIDADE 1
Console.Write("Insira a nota média: ");
int notaMedia = int.Parse(Console.ReadLine());
Console.WriteLine(notaMedia);

if (notaMedia >= 5)
{
    Console.WriteLine($"Parabéns, você passou com {notaMedia}.");
}

List<string> linguagens = new(){ "C#", "Java", "JavaScript" };
Console.WriteLine(linguagens[0]);

// JOGO

Random aleatori = new Random();
int numero =  aleatori.Next(1, 101);

do
{
    Console.Write("Insira um número: ");
    int tentativa = int.Parse(Console.ReadLine());

    if(tentativa == numero)
    {
        Console.WriteLine("Parabéns, você venceu o jogo!");
            break; }
    else if(tentativa > numero)
    {
        Console.WriteLine($"O número é menor que {tentativa}");
    }
    else
    {
        Console.WriteLine($"O número é maior que {tentativa}");
    }

} while(true);
Console.WriteLine("O jogo acabou. Você acertou o número secreto!");