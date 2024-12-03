public class Personagem
{
    public int level;
    public string nome;
    public int vida;
    public int forca;
    public int inteligencia;
    public int vontade;

    public bool vivo = true;

    public Personagem(string nome, int forca, int inteligencia, int vontade, int level)
    {
        this.level = level;
        this.nome = nome;
        this.forca = forca;
        this.inteligencia = inteligencia;
        this.vontade = vontade;
        this.vida = vontade + 3;
    }

    public Personagem(string nome, int forca, int inteligencia, int vontade)
        : this(nome, forca, inteligencia, vontade, 1) 
    {
    }

    public void Atacar(Personagem defensor)
    {
        int dano = this.forca + this.level;
        defensor.vida -= dano;
        Console.WriteLine($"Atacante: {this.nome} infligiu {dano} de dano em {defensor.nome}");
    }

    public void VerificarMorte()
    {
        if (this.vida <= 0)
        {
            this.vivo = false;
            Console.WriteLine($"{this.nome} foi derrotado!");
        }
    }

    public void Descansar()
    {
        this.vida += 3;
    }
}