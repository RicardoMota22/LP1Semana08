using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit soldier = new MilitaryUnit(mov: 5,health: 100, attackPower: 20);
            SettlerUnit worker = new SettlerUnit();

            Console.WriteLine("Soldier:");
            soldier.Move(3);

            Console.WriteLine("Worker:");
            worker.Move(2);

            
            Console.WriteLine($"Soldier Health: {soldier.Health}, Cost: {soldier.Cost}");
            Console.WriteLine($"Worker Health: {worker.Health}, Cost: {worker.Cost}");
        }
    }
}
