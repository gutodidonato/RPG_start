public class Quest
{
    public string descricao;
    public bool completada;
    public int dificuldade;

    public Quest(string descricao, int dificuldade)
    {
        this.descricao = descricao;
        this.dificuldade = dificuldade;
        this.completada = false;
    }

    public void Completar(Personagem personagem)
    {
        completada = true;
        Console.WriteLine($"Você completou a missão: {descricao}");
        Recompensar(personagem);
    }

    public void Falhar()
    {
        completada = false;
        Console.WriteLine($"Você falhou na missão: {descricao}");
    }

    public void Recompensar(Personagem personagem)
    {
        personagem.level += this.dificuldade;
        Console.WriteLine($"{personagem.nome} ganhou {this.dificuldade} de nível!");
    }
}