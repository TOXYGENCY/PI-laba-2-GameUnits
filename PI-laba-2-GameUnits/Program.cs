namespace PI_laba_2_GameUnits
{
    public static class TankExtension
    {
        public static bool IsDead(this Tank t)
        /// Метод расширитель для танка. Зачем? В задании написано про расширители, а так, у меня они не требуются
        {
            Console.WriteLine($"Танк {t.Armor} уничтожен? - {t.HealthPoints == 0} \n");
            return t.HealthPoints == 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Наполняем массив всеми юнитами
            var unitsList = new UnitsList
            {
                new Soldier { HealthPoints = 50, DistanceToExplosion = 80 },
                new Soldier { HealthPoints = 60, DistanceToExplosion = 1 },
                new Tank { HealthPoints = 150, Armor = 20, DistanceToExplosion = 20 },
                new Tank { HealthPoints = 660, Armor = 11, DistanceToExplosion = 45 },
                new Tank { HealthPoints = 74, Armor = 0, DistanceToExplosion = 0.2 }
            };

            unitsList.Explosion(77.8);
        }
    }
}