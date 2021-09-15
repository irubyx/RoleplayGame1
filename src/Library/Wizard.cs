using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard
    {
        private string name { get; set;}
        private int health { get; set;}
        private int attack { get; set;} 
        private int armor { get; set;}
        private List<Item> inventory;
        private SpellBook spellBook; 

        public Wizard(string name, SpellBook book)
        {
            this.name = $"Mago {name}";
            this.health = 100;
            this.attack = 25;
            this.armor = 35;
            this.inventory = new List<Item> {};
            this.spellBook = book;
        }
        
        public void AttackEnemy(Wizard characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor) + this.spellBook.GetDamage());
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void AttackEnemy(Elf characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor) + this.spellBook.GetDamage());
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void AttackEnemy(Knight characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor) + this.spellBook.GetDamage());
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void AttackEnemy(Dwarf characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor) + this.spellBook.GetDamage());
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
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

        public void EquipItem(Item item)
        {
            this.inventory.Add(item);
            this.attack = this.attack + item.ReturnDamage();
            this.armor = this.armor + item.ReturnArmor();
        }

        public void UnequipItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.Remove(item);
        }
        
        public int ReturnArmor()
        {
            return this.armor;
        }
        public int ReturnAttack()
        {
            return this.attack;
        }
        public int CurrentHealth()
        {
            return this.health;
        }
        public void RestoreHealth()
        {
            this.health = 100;
        }
    }
}