namespace Library
{
    public class Elf
    {
        private string Name {get; set;}
        private int health  {get; set;}
        private int attack {get; set;}
    
        public Elf (string name)
        {
            this.Name = name;
            this.attack = 25;

        }
        public void AttackEnemy(Knight enemyToAtack)
        {
            enemyToAtack.health -= this.attack;
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}")
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}")
        }

        public void AttackEnemy(Wizard enemyToAtack)
        {
            enemyToAtack.health -= this.attack;
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}")
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}")
        }

        public void AttackEnemy(Dwarf enemyToAtack)
        {
            enemyToAtack.health -= this.attack;
            Console.WriteLine($"{this.name} ataca a {enemyToAtack.name}")
            Console.WriteLine($"Se le quita {this.attack} puntos de vida a {enemyToAtack.name}")
        }

        // se pueden defender? la defensa se le suma en los métodos desde
        // donde lo atacan (clase del personaje que ataca) para no restar tanta vida?
    }
}