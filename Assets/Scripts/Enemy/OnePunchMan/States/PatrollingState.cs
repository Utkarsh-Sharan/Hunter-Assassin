using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern.Enemy
{
    public class PatrollingState : IState
    {
        public EnemyController Owner { get; set; }
        private IStateMachine stateMachine;

        public PatrollingState(IStateMachine stateMachine) => this.stateMachine = stateMachine;

        public void OnStateEnter()
        {
            throw new System.NotImplementedException();
        }

        void IState.Update()
        {
            throw new System.NotImplementedException();
        }

        public void OnStateExit()
        {
            throw new System.NotImplementedException();
        }
    }
}