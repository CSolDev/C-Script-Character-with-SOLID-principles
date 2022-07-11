using Action;
using UnityEngine;

namespace Character
{ 
public class SecondCharacterAction : MonoBehaviour, IWalk, IRun, IAttack, IDie, ISwim
{
    public void Walk() { }
    public void Run() { }
    public void Attack() { }
    public void Die() { }
    public void Jump() { }
    public void Swim() { }
}
}