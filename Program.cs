
Inicio ();
void Inicio () {
    ConsoleKeyInfo input;
    Robo robo = new Robo(new Coordenada(0, 0), 1);
    do {
        Console.Clear();
        MostrarSala (robo, 40, 20);
        input = Console.ReadKey();

        switch (input.Key) {
            case ConsoleKey.UpArrow: 
                if(robo.PosicaoAtual.Linha - robo.Passo >= 0)
                    robo.AndarCima();
            break;
            case ConsoleKey.DownArrow: 
                if(robo.PosicaoAtual.Linha + robo.Passo < 20)
                    robo.AndarBaixo();
            break;
            case ConsoleKey.RightArrow: 
                if(robo.PosicaoAtual.Coluna + robo.Passo < 40)
                    robo.AndarDireita();
            break;
            case ConsoleKey.LeftArrow: 
                if(robo.PosicaoAtual.Coluna - robo.Passo >= 0)
                    robo.AndarEsquerda();
            break;
        }
    } while (input.Key != ConsoleKey.Escape);
}

void MostrarSala (Robo robo, int tamanhoLinha, int tamanhoColuna ) 
{
    Console.Write("╭");
    for (int i = 0; i < tamanhoLinha; i++) 
    {
        Console.Write("─");
    }
    Console.WriteLine("╮");

    for (int i = 0; i < tamanhoColuna; i++)
    {
        Console.Write("│");
        for (int j = 0; j < tamanhoLinha; j++)
        {
            if(robo.PosicaoAtual.Linha == i && robo.PosicaoAtual.Coluna == j)
            {
                Console.Write("1");
            } else {
                Console.Write(" ");
            }
        }
        Console.WriteLine("│");
    }
    
    Console.Write("╰");
    for (int i = 0; i < tamanhoLinha; i++) 
    {
        Console.Write("─");
    }
    Console.WriteLine("╯");
}