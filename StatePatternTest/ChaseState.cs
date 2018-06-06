using System;

namespace StatePatternTest
{
    public class ChaseState : EnemyState
    {
        private Enemy enemy;
        private int distance;

        public ChaseState(Enemy enemy, int distance)
        {
            this.enemy = enemy;
            this.distance = distance;

            Chase();
            Engage();
            Evade();
        }

        public void Chase()
        {
            if (distance >= 200)
            {
                Console.WriteLine("Enemy chasing");
                enemy.SetEnemyState(enemy.StartChasing());
            }            
        }

        public void Engage()
        {
            
        }

        public void Evade()
        {
            
        }
    }
}
