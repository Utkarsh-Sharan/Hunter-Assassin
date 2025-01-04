using StatePattern.Main;
using StatePattern.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace StatePattern.Enemy
{
    public class CloningState<T> : IState where T : EnemyController
    {
        public EnemyController Owner { get ; set ; }
        protected GenericStateMachine<T> stateMachine;

        public CloningState(GenericStateMachine<T> stateMachine) => this.stateMachine = stateMachine;

        public void OnStateEnter()
        {
            CreateClones();
        }

        private void CreateClones()
        {
            for (int i = 0; i < Owner.Data.numberOfClones; ++i)
            {
                EnemyController hitManController = GameService.Instance.EnemyService.CreateEnemy(Owner.Data) as HitManController;
            }
        }

        public void Update()
        {

        }

        public void OnStateExit()
        {
            
        }
    }
}