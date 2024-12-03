class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do seu personagem:");
        string nome = Console.ReadLine();
        Personagem jogador = new Personagem(nome, 10, 5, 8);

        List<Inimigo> inimigos = new List<Inimigo>
        {
            new Inimigo("Goblin", 5, 2, 3, "Monstro", 1),
            new Inimigo("Rodrigo o maldoso", 7, 3, 4, "Humano", 1),
            new Inimigo("Orc", 6, 1, 5, "Monstro", 1)
        };

        Quest quest = new Quest("Derrote os inimigos!", 2);

        Console.WriteLine($"Bem-vindo, {jogador.nome}! Sua missão é: {quest.descricao}");

        foreach (var inimigo in inimigos)
        {
            Console.WriteLine($"\nVocê encontrou um inimigo: {inimigo.nome}!");

            while (jogador.vivo && inimigo.vivo)
            {
                jogador.Atacar(inimigo);
                inimigo.VerificarMorte();

                if (inimigo.vivo)
                {
                    inimigo.Atacar(jogador);
                    jogador.VerificarMorte();
                }
            }

            if (jogador.vivo)
            {
                quest.Completar(jogador);
            }
            else
            {
                quest.Falhar();
                break; 
            }
        }

        if (jogador.vivo)
        {
            Console.WriteLine($"{jogador.nome} derrotou todos os inimigos!");
        }
    }
}