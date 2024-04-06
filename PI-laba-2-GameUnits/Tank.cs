using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_laba_2_GameUnits
{
    public class Tank : Unit
    {
        public byte Armor { get; set; } // Броня будет от 0 до 100 потому что будут махинации с процентами
        protected override double CalculateDamage(double DistanceToExplosion, double ExplosionPower)
        { // Переопределим метод вычисления урона для конкретно танка
            var Damage = ExplosionPower / DistanceToExplosion;
            Damage -= Damage * (Armor / 100);
            return Damage;
        }
    }
}
