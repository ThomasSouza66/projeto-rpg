namespace ProjetoRPG.Entities;

public class Wizard : Hero
{
    public Wizard(string nome, int nivel) : base(nome, nivel)
    {
        this.name = nome;
        this.level = nivel;
        this.hp = TotalHp(nivel);
        this.Type = "Wizard";

    }

    public override string Attack()
    {
        return ($"{this.name} atacou com uma magia.");
    }

    public override int TotalHp(int lvl)
    {
        lvl = Convert.ToInt32(7 + (lvl / 2));
        return lvl;
    }
}