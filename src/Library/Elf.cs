using System;
using System.Collections.Generic;
namespace Library
{
    public class Elf
    {
        private string name {get; set;}
        private int health;
        private int attack {get; set;}
        private int armor {get; set;}  
        private List<Item> inventory;
    
        public Elf (string name)
        {
            this.name = name;
            this.health = 100;
            this.attack = 35;
            this.armor = 5;
            this.inventory = new List<Item>();
        }
        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }
        public void RecieveDamage(int damage)
        {
            this.health = this.health - damage;
        }
        public void AttackEnemy(Knight enemyToAtack)
        {
            Console.WriteLine($"Se ataca a {enemyToAtack.ReturnName()}.");
            enemyToAtack.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {enemyToAtack.ReturnName()}");
        }

        public void AttackEnemy(Wizard enemyToAtack)
        {
            Console.WriteLine($"Se ataca a {enemyToAtack.ReturnName()}.");
            enemyToAtack.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {enemyToAtack.ReturnName()}");
        }

        public void AttackEnemy(Dwarf enemyToAtack)
        {
            Console.WriteLine($"Se ataca a {enemyToAtack.ReturnName()}.");
            enemyToAtack.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {enemyToAtack.ReturnName()}");
        }
        public void AttackEnemy(Elf enemyToAtack)
        {
            Console.WriteLine($"Se ataca a {enemyToAtack.ReturnName()}.");
            enemyToAtack.RecieveDamage(this.attack);
            Console.WriteLine($"-{this.attack} de vida a {enemyToAtack.ReturnName()}");
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
        public List<Item> ReturnInventory()
        {
            return this.inventory;
        }
    }
}