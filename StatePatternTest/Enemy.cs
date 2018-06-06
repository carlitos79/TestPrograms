using System;

namespace StatePatternTest
{
    public class Enemy
    {
        private EnemyState chasing;
        private EnemyState evading;
        private EnemyState engaging;
        private EnemyState currEnemyState;

        public Enemy(int distance)
        {
            chasing = new ChaseState(this, distance);
            evading = new EvadeState(this, distance);
            engaging = new EngageState(this, distance);

            currEnemyState = chasing;
        }

        public EnemyState GetEnemyCurrentState()
        {
            return currEnemyState;
        }

        public void SetEnemyState(EnemyState newEnemyState)
        {
            currEnemyState = newEnemyState;
        }

        public EnemyState StartChasing()
        {
            return chasing;
        }

        public EnemyState StartEvading()
        {
            return evading;
        }

        public EnemyState StartEngaging()
        {
            return engaging;
        }
    }
}
