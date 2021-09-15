using System;
namespace Library
{
    public class Elf
    {
        private string name {get; set;}
        private int health  {get; set;}
        private int attack {get; set;}

        private int armor {get; set;}  
        private List<Item> inventory;
    
        public Elf (string name)
        {
            this.name = name;
            this.health = 100;
            this.attack = 35;
            this.armor = 5;
            this.inventory = new List<Item> {};

        }
        public void AttackEnemy(Knight enemyToAtack)
        {
            enemyToAtack.health = enemyToAtack.health - (this.attack - (this.attack * (enemyToAtack.armor / 100)));
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}");
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}");
        }

        public void AttackEnemy(Wizard enemyToAtack)
        {
            enemyToAtack.health = enemyToAtack.health - (this.attack - (this.attack * (enemyToAtack.armor / 100)));
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}");
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}");
        }

        public void AttackEnemy(Dwarf enemyToAtack)
        {
            
            enemyToAtack.health = enemyToAtack.health - (this.attack - (this.attack * (enemyToAtack.armor / 100)));
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}");
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}");
        }
        public void AttackEnemy(Elf enemyToAtack)
        {
            enemyToAtack.health = enemyToAtack.health - (this.attack - (this.attack * (enemyToAtack.armor / 100)));
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}");
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}");
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