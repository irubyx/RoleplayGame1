using System;
namespace Library
{
    public class Dwarf
    {
        private int health { get; set; }
        private int armor { get; set; }
        private int attack { get; set; }
        private string name { get; }
        private List<Item> inventory;

        public Dwarf(string name)
        {
            this.name = dwarf;
            this.health = 100;
            this.armor = 40
            this.attack = 15
            this.inventory = new List<item> { };
        }
        public void AttackEnemy(Wizard characterEnemy)
        {
            Console.WriteLine($"Se atacó a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor));
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void AttackEnemy(Elf characterEnemy)
        {
            Console.WriteLine($"Se atacó a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor));
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void AttackEnemy(Knight characterEnemy)
        {
            Console.WriteLine($"Se atacó a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor));
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void AttackEnemy(Dwarf characterEnemy)
        {
            Console.WriteLine($"Se atacó a {characterEnemy.name}.");
            characterEnemy.health = characterEnemy.health - (this.attack - (this.attack * characterEnemy.armor));
            Console.WriteLine($"-{(this.attack - (this.attack * characterEnemy.armor))} de vida a {characterEnemy.name}");
        }
        public void EquipItem(Item item)
        {
            this.inventory.Add(item);
            this.attack = this.attack + item.ReturnDamage();
            this.armor = this.armor + item.ReturnArmor();
        }
        public void delateItem(Item item)
        {
            this.attack = this.attack - item.ReturnDamage();
            this.armor = this.armor - item.ReturnArmor();
            this.inventory.remove(item);
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


