namespace ProjetoRPG.Entities;

public class Thief : Hero
{
    public Thief(string nome, int nivel) : base(nome, nivel)
    {
        this.name = nome;
        this.level = nivel;
        this.hp = TotalHp(nivel);
        this.Type = "Thief";
    }

    public override int TotalHp(int lvl)
    {
        lvl = Convert.ToInt32(3 + (lvl / 2));
        return lvl;
    }

    public override string Attack()
    {
        return ($"{this.name} atacou o inimigo furtivamente com uma adaga.");
    }

    public string CriticalAttack(int bonus)
    {
        return ($"{this.name} executou um ataque crítico causando {bonus} de dano extra ao inimigo.");
    }
}