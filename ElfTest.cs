using NUnit.Framework;
namespace Test.Library
{
    public class ElfTest
    {
        [Setup]
        public void Setup()
        {
            Elf elfa = new Elf("Idril");
        }

        [Test]
        public void ReciveDamageTest()
        {
            int damage = 7;
            int expectedHealth = 100 - 7;
            elfa.RecieveDamage(damage);
            Assert.AreEqual(expectedHealth, elfa.CurrentHealth());
        }

        [Test]
        public void AttackEnemyKnightTest()
        {
            Knight knight = new Knight("Wade");
            elfa.AttackKnight(knight);
            expectedHealth = 100 - 35;
            Assert.AreEqual(expectedHealth, knight.CurrentHealth());
        }

        [Test]
        public void EquipItemAttackTest()
        {
            Item itemAtaque = new Item("Fuego", 15, 0);
            elfa.EquipItem(itemAtaque);
            int expectedAttack = 35 + 15;
            int expectedArmor = 5;
            Assert.IsNotEmpty(elfa.ReturnInventory());
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            Assert.AreEqual(expectedArmor, elfa.ReturnArmor());
        }

        [Test]
        public void EquipItemArmorTest()
        {
            Item itemArmor = new Item("Pocion", 15, 0);
            elfa.EquipItem(itemArmor);
            int expectedAttack = 35;
            int expectedArmor = 5 + 15;
            Assert.IsNotEmpty(elfa.ReturnInventory());
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            Assert.AreEqual(expectedArmor, elfa.ReturnArmor());
        }
        
        [Test]
        public void UnEquipItemTest()
        {
            Item itemAtaque = new Item("Fuego", 15, 0);
            elfa.EquipItem(itemAtaque);
            int expectedAttack = 35 + 15;
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            
            elfa.UnEquipItem(itemAtaque);
            expectedAttack = 35 - 15;
            Assert.AreEqual(expectedAttack, elfa.ReturnAttack());
            Assert.IsEmpty(elfa.ReturnInventory());
        }

    }
}