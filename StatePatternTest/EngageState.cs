using System;

namespace StatePatternTest
{
    public class EngageState : EnemyState
    {
        private Enemy enemy;
        private int distance;

        public EngageState(Enemy enemy, int distance)
        {
            this.enemy = enemy;
            this.distance = distance;

            Chase();
            Engage();
            Evade();
        }

        public void Chase()
        {
            
        }

        public void Engage()
        {
            if (distance == 200)
            {
                Console.WriteLine("Enemy engaging");
                enemy.SetEnemyState(enemy.StartEngaging());
            }
        }

        public void Evade()
        {
            
        }
    }
}
