using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PI_laba_2_GameUnits
{
    public abstract class Unit
    {
        public double HealthPoints { get; set; }
        public double DistanceToExplosion { get; set; } 

        protected virtual double CalculateDamage(double DistanceToExplosion, double ExplosionPower) // protected, потому что будет использоваться только внутри этого семейства классов
        { // Сделаю общий метод по вычислению общего урона, ибо это значение нужно всем
            if (DistanceToExplosion == 0) { DistanceToExplosion = +1; }
            var Damage = ExplosionPower / DistanceToExplosion;
            Console.WriteLine($"Базовый CalculateDamage({DistanceToExplosion}; {ExplosionPower}) = {Damage} - базовый урон");
            return Damage;
        }

        public double CalculateHP(double ExplosionPower)
        { // Общий рассчет ХП (логика ХП везде одинаковая, а вот вычитаемый урон зависит от юнита)
            var newHP = HealthPoints - CalculateDamage(this.DistanceToExplosion, ExplosionPower);
            if (newHP < 0) { newHP = 0; }
            Console.WriteLine($"CalculateHP({ExplosionPower}) = {newHP} - здоровье теперь");
            return newHP;
        }

    }
}
