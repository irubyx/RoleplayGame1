using System;
using System.Collections.Generic;

namespace Library
{
    class Knight
    {
        private int health {get; set;}
        private int attack {get; set;}
        private int armor {get; set;}
        private string name {get;}
        private List<Item> inventory;
        
        public Knight(string name)
        {
            this.name = name;
            this.health = 100;
            this.attack = 25;
            this.armor = 35;
            this.inventory = new List<Item> {};
        }

        public void AttackEnemy(Wizard wizard)
        {
            Console.WriteLine($"Se ataca a {wizard.name}.");
            wizard.health = wizard.health - (this.attack - (this.attack * (wizard.armor / 100)));
            Console.WriteLine($"-{(this.attack - (this.attack * wizard.armor))} de vida a {wizard.name}");
        }
        public void AttackEnemy(Elf elf)
        {
            Console.WriteLine($"Se ataca a {elf.name}.");
            elf.health = elf.health - (this.attack - (this.attack * (elf.armor / 100)));
            Console.WriteLine($"-{(this.attack - (this.attack * elf.armor))} de vida a {elf.name}");
        }
        public void AttackEnemy(Dwarf dwarf)
        {
            Console.WriteLine($"Se ataca a {dwarf.name}.");
            dwarf.health = dwarf.health - (this.attack - (this.attack * (dwarf.armor / 100)));
            Console.WriteLine($"-{(this.attack - (this.attack * dwarf.armor))} de vida a {dwarf.name}");
        }
        public void AttackEnemy(Knight knight)
        {
            Console.WriteLine($"Se ataca a {knight.name}.");
            knight.health = knight.health - (this.attack - (this.attack * (knight.armor / 100)));
            Console.WriteLine($"-{(this.attack - (this.attack * knight.armor))} de vida a {knight.name}");
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