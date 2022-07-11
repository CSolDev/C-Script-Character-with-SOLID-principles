using Action;

namespace Character.Enemies
{
    public interface IBoss: IWalk, IAttack, IDie
    {
        string Type { get; }
    }
}