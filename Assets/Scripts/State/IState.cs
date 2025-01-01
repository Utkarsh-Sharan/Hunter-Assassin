using StatePattern.Enemy;

namespace StatePattern.State
{
    public interface IState
    {
        public OnePunchManController Owner { get; set; }

        public void OnStateEnter();

        public void Update();

        public void OnStateExit();
    }
}