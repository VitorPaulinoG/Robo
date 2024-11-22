public class Robo 
{
    public Coordenada PosicaoAtual { get; set; }
    public int Passo { get; set; }

    public Robo (Coordenada posicaoInicial, int passo)
    {
        PosicaoAtual = posicaoInicial;
        Passo = passo;
    }

    public void AndarCima() => PosicaoAtual.Linha -= Passo;
    public void AndarBaixo() => PosicaoAtual.Linha += Passo;
    public void AndarDireita() => PosicaoAtual.Coluna += Passo;
    public void AndarEsquerda() => PosicaoAtual.Coluna -= Passo;
}