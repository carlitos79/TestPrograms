using System;

namespace StatePatternTest
{
    public class EvadeState : EnemyState
    {
        private Enemy enemy;
        private int distance;

        public EvadeState(Enemy enemy, int distance)
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
                      
        }

        public void Evade()
        {
            if (distance <= 100)
            {
                Console.WriteLine("Enemy evading");
                enemy.SetEnemyState(enemy.StartEvading());                
            }
        }
    }
}
