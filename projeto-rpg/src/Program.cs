// See https://aka.ms/new-console-template for more information

using ProjetoRPG.Entities;

Knight hero = new Knight("Arus",15);
Wizard mage = new Wizard("Merlin",50);
Thief lad = new Thief("Robin",20);

Console.WriteLine(hero.ToString());
Console.WriteLine(mage.ToString());
Console.WriteLine(lad.ToString());
Console.WriteLine();

Console.WriteLine(lad.Attack());
Console.WriteLine(lad.CriticalAttack(10));
Console.WriteLine(lad.LevelUp(1));
Console.WriteLine();

Console.WriteLine(mage.Attack());
Console.WriteLine(mage.LevelUp(5));
Console.WriteLine();

Console.WriteLine(hero.Attack());
Console.WriteLine(hero.LevelUp(2));
Console.WriteLine();

Console.WriteLine(hero.ToString());
Console.WriteLine(mage.ToString());
Console.WriteLine(lad.ToString());