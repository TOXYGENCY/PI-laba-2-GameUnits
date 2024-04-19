namespace PI_laba_2_GameUnits
{
    public class UnitsList : List<Unit>
    {
        public void Explosion(double ExplosionPower)
        {
            foreach (Unit u in this)
            {
                if (u != null)
                {
                    u.HealthPoints = u.CalculateHP(ExplosionPower);
                    if (u.HealthPoints <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{u.GetType().Name}({u.HealthPoints}, {u.DistanceToExplosion}) уничтожен.");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
