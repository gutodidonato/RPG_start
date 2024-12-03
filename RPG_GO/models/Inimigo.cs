public class Inimigo : Personagem
{
    public string tipo;

    public Inimigo(string nome, int forca, int inteligencia, int vontade, string tipo, int level) 
        : base(nome, forca, inteligencia, vontade, level)
    {
        this.tipo = tipo;
    }

}