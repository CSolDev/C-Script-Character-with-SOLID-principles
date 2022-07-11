using Action;
using UnityEngine;


namespace Character
{
    public class FirstCharacterActions : MonoBehaviour, IWalk, IRun, IAttack, IDie, IJump
{
    public void Walk() { }
    public void Run() { }
    public void Attack() { }
    public void Die() { }
    public void Jump() { }
}
}