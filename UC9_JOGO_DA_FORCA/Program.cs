int i, tentativas;
int encontrado = 0;
string letra = "";
string[] palavra_secreta = new string[10];
string[] palavra_visivel = new string[10];

for (i = 0; i <= 9; i++)
{
    Console.WriteLine((i + 1) + "ª Letra da palavra (total de 10 letras)");
    palavra_secreta[i] = Console.ReadLine();
}

for (i = 0; i <= 9; i++)
{
    Console.Write(palavra_secreta[i] + " ");
}
Console.WriteLine("");
Console.WriteLine("Pressione ENTER para continuar...");
Console.ReadLine();

Console.Clear();

tentativas = 0;

while (tentativas < 10)
{
    // SEMPRE MOSTRAR A PALAVRA EM JOGO NA TELA...
    Console.Clear();
    for (i = 0; i <= 9; i++)
    {
        Console.Write(palavra_visivel[i] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("Você já ERROU " + tentativas + " vezes! (Máximo de 10 ERROS!)");
    Console.WriteLine("");

    // Usuário informa uma LETRA para tentativa de acerto...
    Console.WriteLine("Qual LETRA deseja tentar?");
    letra = Console.ReadLine();

    // JOGO verifica se a LETRA informada EXISTE na Palavra Secreta...
    for (i = 0; i < 10; i++)
    {
        // Se LETRA existe, JOGO mostra a LETRA na tela e na posição para o usuário;
        if (letra == palavra_secreta[i])
        {
            palavra_visivel[i] = letra;
            encontrado = 1;
        }
    }
    // Se LETRA não existe, JOGO informa Letra Incorreta!
    if (encontrado == 0)
    {
        Console.WriteLine("LETRA não encontrada!");
        tentativas++;
    }

    encontrado = 0;

    Console.WriteLine("");
    Console.WriteLine("Pressione ENTER para continuar...");
    Console.ReadLine();
}