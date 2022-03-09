namespace ProjetoRPG.Entities;

public abstract class Hero
{
    public Hero(string nome, int nivel)
    {
        this.name = nome;
        this.level = nivel;
        this.level = TotalHp(nivel);
        this.Type = "Hero";
    }

    protected string Type;
    protected string name { get; set; }

    protected int level { get; set; }

    protected int hp { get; set; }

    public virtual int TotalHp(int lvl)
    {
        return (lvl + 10);
    }

    public virtual string Attack()
    {
        return ($"{this.name} executou um ataque.");
    }

    public string LevelUp(int lvl)
    {
        this.level += lvl;
        string message;
        if (lvl>1)
        {
            message = ($"{this.name} subiu {lvl} níveis e agora está nível {level}.");
        }
        else
        {
            message = ($"{this.name} subiu de nivel e agora está níel {level}");
        }

        return message;
    }

    public string ToString()
    {
        return ($"{this.name} - Level:{this.level} - HP:{this.hp} - {this.Type}");
    }
    
}