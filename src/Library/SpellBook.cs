using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class SpellBook
    {
        private string name;
        private List<Spell> spells;

        public SpellBook(string name)
        {
            this.name = name;
        }

        public void AddSpell(Spell spell)
        {
            if(!spells.Contains(spell))
            {
                spells.Add(spell);
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
    }
}