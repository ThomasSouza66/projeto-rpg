namespace ProjetoRPG.Entities;

public class Knight : Hero
{
    public Knight(string nome, int nivel) : base(nome, nivel)
    {
        this.name = nome;
        this.level = nivel;
        this.hp = TotalHp(nivel);
        this.Type = "Knight";
    }

    public override string Attack()
    {
        return ($"{this.name} atacou o inimigo com uma espada.");
    }

    public override int TotalHp(int lvl)
    {
        lvl = (15 + (lvl*2)); 
        return lvl;
    }
}