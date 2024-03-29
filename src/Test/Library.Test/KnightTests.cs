using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class KnightTests
    {

        [Test]
        public void EquipItem1()
        {
            Knight knight = new Knight("Dark Knight");
            Item item = new Item("Espada", 20, 0);
            int expectedDamage = 45;
            int expectedArmor = 35;
            knight.EquipItem(item);

            Assert.IsNotEmpty(knight.ReturnInventory());
            Assert.AreEqual(knight.ReturnAttack(), expectedDamage);
            Assert.AreEqual(knight.ReturnArmor(), expectedArmor);
        }

        [Test]
        public void EquipItem2()
        {
            Knight knight = new Knight("Dark Knight");
            Item item = new Item("Armadura", 0, 20);
            int expectedDamage = 25;
            int expectedArmor = 55;
            knight.EquipItem(item);

            Assert.IsNotEmpty(knight.ReturnInventory());
            Assert.AreEqual(knight.ReturnAttack(), expectedDamage);
            Assert.AreEqual(knight.ReturnArmor(), expectedArmor);
        }

        [Test]
        public void UnequipItem()
        {
            Knight knight = new Knight("Dark Knight");
            Item item = new Item("Espada", 20, 0);
            int expectedDamage = 25;
            int expectedArmor = 35;
            knight.EquipItem(item);

            knight.UnequipItem(item);

            Assert.IsEmpty(knight.ReturnInventory());
            Assert.AreEqual(knight.ReturnAttack(), expectedDamage);
            Assert.AreEqual(knight.ReturnArmor(), expectedArmor);            
        }

        [Test]
        public void AttackTest1()
        {
            Knight knight1 = new Knight("Atacante");
            Knight knight2 = new Knight("Defensor");
            int expectedHealth = 75;

            knight1.AttackEnemy(knight2);

            Assert.AreEqual(expectedHealth, knight2.CurrentHealth());
        }

        [Test]
        public void AttackTest2()
        {
            Knight knight1 = new Knight("Atacante");
            Elf elf = new Elf("Defensor");
            int expectedHealth = 75;

            knight1.AttackEnemy(elf);

            Assert.AreEqual(expectedHealth, elf.CurrentHealth());
        }

        [Test]
        public void RestoreHP()
        {
            Knight knight = new Knight("Defensor");
            Elf elf = new Elf("Atacante");
            int expectedHealth = 100;

            elf.AttackEnemy(knight);

            knight.RestoreHealth();

            Assert.AreEqual(expectedHealth, knight.CurrentHealth());
        }
    }
}
