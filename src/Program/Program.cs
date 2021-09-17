using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf elf1 = new Elf("Elf1");
            Elf elf2 = new Elf("Elf2");
            Item item1 = new Item("Fuego", 10, 0);
            Item item2 = new Item("Escudo", 10, 5);
            elf1.EquipItem(item1);
            elf1.EquipItem(item2);
            
            while (elf2.CurrentHealth()>0)
            {
                elf1.AttackElf(elf2);
                elf2.AttackElf(elf1);
            }
        }
    }
}
