namespace PI_laba_2_GameUnits
{
    public class Tank : Unit
    {
        public byte Armor { get; set; } // Броня будет от 0 до 100 потому что будут махинации с процентами
        protected override double CalculateDamage(double DistanceToExplosion, double ExplosionPower)
        /// Переопределим метод вычисления урона для конкретно танка
        {
            if (DistanceToExplosion == 0) { DistanceToExplosion = +0.1; }
            var Damage = Math.Round(ExplosionPower / DistanceToExplosion, 1);
            Damage -= Damage * (Armor / 100);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"CalculateDamage({DistanceToExplosion}; {ExplosionPower}) = {Damage} - урон танку");
            Console.ResetColor();
            return Damage;
        }
    }
}
