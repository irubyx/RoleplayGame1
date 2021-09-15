using System;

namespace Library
{
    public class Wizard
    {
        private string name { get; set;}
        private int health { get; set;}
        private int attack { get; set;} 
        private int armor { get; set;}
        private List<Item> inventory { get; set;}

        public Wizard(string name)
        {
            this.name = $"El mago {name}";
        }
        
        public void AttackEnemy(Wizard characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}");
            characterEnemy.health -= this.attack;
            Console.WriteLine($"-{this.attack} de vida de {characterEnemy.name}");
        }
        public void AttackEnemy(Elf characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}");
            characterEnemy.health -= this.attack;
            Console.WriteLine($"-{this.attack} de vida de {characterEnemy.name}");
        }
        public void AttackEnemy(Knight characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}");
            characterEnemy.health -= this.attack;
            Console.WriteLine($"-{this.attack} de vida de {characterEnemy.name}");
        }
        public void AttackEnemy(Dwarf characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}");
            characterEnemy.health -= this.attack;
            Console.WriteLine($"-{this.attack} de vida de {characterEnemy.name}");
        }


        public void HealAlly(Wizard characterAlly)
        {
            Console.WriteLine($"Curando a {characterAlly.name}");
            characterAlly.health += 10;
            Console.WriteLine($"+10 de vida de {characterAlly.name}");
        }
        public void HealAlly(Elf characterAlly)
        {
            Console.WriteLine($"Curando a {characterAlly.name}");
            characterAlly.health += 10;
            Console.WriteLine($"+10 de vida de {characterAlly.name}");
        }
        public void HealAlly(Knight characterAlly)
        {
            Console.WriteLine($"Curando a {characterAlly.name}");
            characterAlly.health += 10;
            Console.WriteLine($"+10 de vida de {characterAlly.name}");
        }
        public void HealAlly(Dwarf characterAlly)
        {
            Console.WriteLine($"Curando a {characterAlly.name}");
            characterAlly.health += 10;
            Console.WriteLine($"+10 de vida de {characterAlly.name}");
        }
    }
}