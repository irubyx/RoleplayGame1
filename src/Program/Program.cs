﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main()
        {
            /*Creacion de darkKnight y de los items sword y armor*/
            Knight darkKnight = new Knight("Dark Knight");
            Item sword = new Item("Sword", 15, 0);
            Item armor = new Item("Armor", 0, 20);

            /*Equipado de items a darkKnight*/
            darkKnight.EquipItem(sword);
            darkKnight.EquipItem(armor);

            /*Printeo de stats de darkKnight*/
            Console.WriteLine($"Stats de: {darkKnight.ReturnName()}: ");
            Console.WriteLine($"Attack: {darkKnight.ReturnAttack()}");
            Console.WriteLine($"Armor: {darkKnight.ReturnArmor()}");
            Console.WriteLine($"Health: {darkKnight.CurrentHealth()}");

            /*Creacion de defensor*/
            Knight defensor = new Knight("Defensor");

            /*Combate entre darkKnight y defensor*/
            while ((defensor.CurrentHealth() > 0) & (darkKnight.CurrentHealth() > 0))
            {
                darkKnight.AttackEnemy(defensor);
                Console.WriteLine($"Current health of {defensor.ReturnName()}: {defensor.CurrentHealth()}");
                defensor.AttackEnemy(darkKnight);
                Console.WriteLine($"Current health of {darkKnight.ReturnName()}: {darkKnight.CurrentHealth()}");
            }
            if (defensor.CurrentHealth() <= 0)
            {
                Console.WriteLine($"{darkKnight.ReturnName()} killed {defensor.ReturnName()}.");
            }
            else
            {
                Console.WriteLine($"{defensor.ReturnName()} killed {darkKnight.ReturnName()}.");         
            }

            /*Restauracion de la vida de darkKnight*/
            darkKnight.RestoreHealth();
            Console.WriteLine($"{darkKnight.ReturnName()}'s health has been restored.");
        }
    }
}
