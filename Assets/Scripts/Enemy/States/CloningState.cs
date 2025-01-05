using StatePattern.Main;
using StatePattern.StateMachine;

namespace StatePattern.Enemy
{
    public class CloningState<T> : IState where T : EnemyController
    {
        public EnemyController Owner { get ; set ; }
        protected GenericStateMachine<T> stateMachine;

        public CloningState(GenericStateMachine<T> stateMachine) => this.stateMachine = stateMachine;

        public void OnStateEnter()
        {
            CreateClone();
            CreateClone();
        }

        private void CreateClone()
        {
            CloneManController clone = GameService.Instance.EnemyService.CreateEnemy(Owner.Data) as CloneManController;
            clone.SetCloneCount((Owner as CloneManController).CloneCountLeft - 1);
            clone.Teleport();
            GameService.Instance.EnemyService.AddEnemy(clone);
        }

        public void Update()
        {

        }

        public void OnStateExit()
        {
            
        }
    }
}