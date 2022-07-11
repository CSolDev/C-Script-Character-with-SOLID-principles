using Action;


namespace Character.Enemies
{
    public class Enemy : IWalk, IAttack, IDie
    {
        public void Walk() { }
        public void Attack() { }
        public void Die() { }
    }
}
