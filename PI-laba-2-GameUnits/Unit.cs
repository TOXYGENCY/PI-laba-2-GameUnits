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
        public int DistanceToExplosion { get; set; } 

        protected virtual double CalculateDamage(double DistanceToExplosion, double ExplosionPower) // protected, потому что будет использоваться только внутри этого семейства классов
        { // Сделаю общий метод по вычислению общего урона, ибо это значение нужно всем
            var Damage = ExplosionPower / DistanceToExplosion;
            Console.WriteLine($"CalculateDamage({DistanceToExplosion}, {ExplosionPower}) = {Damage} - базовый урон");
            return Damage;
        }

        
        public double CalculateHP(double DistanceToExplosion, double ExplosionPower)
        { // Общий рассчет ХП
            var newHP = HealthPoints - CalculateDamage(DistanceToExplosion, ExplosionPower);
            Console.WriteLine($"CalculateHP({DistanceToExplosion}, {ExplosionPower}) = {newHP} - здоровье теперь");
            return newHP;
        }

    }
}
