namespace PI_laba_2_GameUnits
{
    public abstract class Unit
    {
        public double HealthPoints { get; set; }
        public double DistanceToExplosion { get; set; }

        protected virtual double CalculateDamage(double DistanceToExplosion, double ExplosionPower)
        /// protected, потому что будет использоваться только внутри этого семейства классов.
        /// Сделаю общий метод по вычислению общего урона, ибо это значение нужно всем.
        {
            if (DistanceToExplosion == 0) { DistanceToExplosion = +1; }
            var Damage = Math.Round(ExplosionPower / DistanceToExplosion, 1);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Базовый CalculateDamage({DistanceToExplosion}; {ExplosionPower}) = {Damage} - базовый урон");
            Console.ResetColor();
            return Damage;
        }

        public double CalculateHP(double ExplosionPower)
        /// Общий рассчет ХП (логика ХП везде одинаковая, а вот вычитаемый урон зависит от юнита
        {
            var newHP = Math.Round(HealthPoints - CalculateDamage(this.DistanceToExplosion, ExplosionPower), 1);
            if (newHP < 0) { newHP = 0; }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"CalculateHP({ExplosionPower}) = {newHP} - здоровье теперь");
            Console.ResetColor();
            return newHP;
        }

    }
}
