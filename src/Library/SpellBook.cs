using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class SpellBook
    {
        private string name;
        public List<Spell> spells { get; private set; }
        public int spellsCount = 0;

        public SpellBook(string name)
        {
            this.name = name;
            this.spells = new List<Spell> {};
        }

        public void AddSpell(Spell spell)
        {
            if(!spells.Contains(spell))
            {
                spells.Add(spell);
                spellsCount++;
            }
            else 
            {
                Console.WriteLine("El hechizo ya se encuentra dentro del libro.");
            }
        }

        public string GetSpells(object stringbuilder)
        {
            StringBuilder informationSpells = new StringBuilder();
            string line = "--------------------\n--------------------\n";

            informationSpells.Append(line);
            informationSpells.Append("List of spells available:\n");
            foreach(Spell spell in spells)
            {
                informationSpells.Append($"Spell: {spell.Name}, type: {spell.Type}, effect: {spell.Effect}p\n");
            }
            informationSpells.Append(line);

            return informationSpells.ToString();
        }

        public int GetDamage()
        {
            int damage = 0;
            foreach (Spell item in spells)
            {
                damage += item.Effect; 
            }
            damage = (damage / 3) + spellsCount;

            return damage;
        }
    }
}