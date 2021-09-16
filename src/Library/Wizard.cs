using System;
using System.Collections.Generic;

namespace Library
{
    public class Wizard
    {
        private string name { get; set;}
        private int health { get; set; }
        public int Health
        {
            set
            {
                this.health = value;
            }
        }
        private int attack { get; set;} 
        private int armor { get; set;}
        private List<Item> inventory { get; set; }
        private SpellBook spellBook; 

        public Wizard(string name, SpellBook book)
        {
            this.name = $"Mago {name}";
            this.health = 50;
            this.attack = 25;
            this.armor = 35;
            this.inventory = new List<Item> {};
            this.spellBook = book;
        }
        
        /// <summary>
        /// El metodo ataca a otro personaje quitandole vida. Existe una sobrecarga para poder admitir el combate entre 
        /// todos los personajes del juego.
        /// </summary>
        /// <param name="characterEnemy"></param>
        public void AttackEnemy(Wizard characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {characterEnemy.ReturnName()}");
        }
        public void AttackEnemy(Elf characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {characterEnemy.ReturnName()}");
        }
        public void AttackEnemy(Knight characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {characterEnemy.ReturnName()}");
        }
        public void AttackEnemy(Dwarf characterEnemy)
        {
            Console.WriteLine($"Se ataca a {characterEnemy.ReturnName()}.");
            characterEnemy.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {characterEnemy.ReturnName()}");
        }

        public void RecieveDamage(int damage)
        {
            this.health = this.health - (damage - (damage * (this.armor / 100)));
        }

        public void HealAlly(Wizard characterAlly)
        {
            characterAlly.health += 10;
        }
        public void HealAlly(Elf characterAlly)
        {
            characterAlly.Health += 10;
        }
        public void HealAlly(Knight characterAlly)
        {
            characterAlly.Health += 10;
        }
        public void HealAlly(Dwarf characterAlly)
        {
            characterAlly.Health += 10;
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
        public List<Item> ReturnInventory()
        {
            return this.inventory;
        }
        
        public string ReturnName()
        {
            return this.name;
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