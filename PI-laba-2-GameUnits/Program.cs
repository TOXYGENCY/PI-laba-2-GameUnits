using System.Threading.Tasks;

namespace PI_laba_2_GameUnits
{
    public static class TankExtension 
    {
        public static bool IsDead(this Tank t)
        { // Метод расширитель для танка. Зачем? В задании написано про расширители, а так, у меня они не требуются 
            Console.WriteLine($"Танк {t.Armor} уничтожен? - {t.HealthPoints == 0} \n");
            return t.HealthPoints == 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var tank1 = new Tank
            {
                HealthPoints = 150,
                Armor = 30,
                DistanceToExplosion = 30
            };

            tank1.HealthPoints = tank1.CalculateHP(40);
            tank1.IsDead();
            

            var tank2000 = new Tank
            {
                HealthPoints = 1999,
                Armor = 99,
                DistanceToExplosion = 0
            };
            tank2000.HealthPoints = tank2000.CalculateHP(100);
            tank2000.IsDead();
        }
}
}